using GUI.Klassen.ERM;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GUI.Klassen
{
    public class ERMTable
    {
        private List<PropertyInfo> attributes = new List<PropertyInfo>();

        public ERMTable(object id)
        {
            // Alle definierte Attributen in der Klasse auflisten
            foreach (PropertyInfo attribute in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (attribute.CanWrite & attribute.CanRead)
                {
                    this.attributes.Add(attribute);
                }
            }
            // Zeile von der Datenbank-Tabelle holen
            if (id != null)
            {
                string query = "SELECT TOP 1 {0} FROM {1} WHERE {2} = {3};";
                string formattedQuery = string.Format(query, this.getQueryAttributes(), this.getTableName(), this.attributes[0].Name, id);
                DataTable table = Program.sqlUser.select(formattedQuery);
                foreach (DataRow row in table.Rows)
                {
                    this.convert(row, true);
                }
            }
        }

        public virtual string getTableName()
        {
            // Holt Name von der Klasse und fügt ein s vorne hinzu, um zum pluralisieren.
            return this.GetType().Name + "s";
        }

        public List<dynamic> selectAll(string condition = "")
        {
            /*
             * Gibt alle Objekten gemäss CONDITION-Klausel zurück und returniert eine Liste von Objekten
             */
            List<object> objectList = new List<object>();
            string query = "SELECT {0} FROM {1} {2};";
            string formattedQuery = string.Format(query, this.getQueryAttributes(), this.getTableName(), condition);
            DataTable table = Program.sqlUser.select(formattedQuery);
            foreach (DataRow row in table.Rows)
            {
                objectList.Add(this.convert(row));
            }
            return objectList;
        }

        protected string getQueryAttributes(int startCount = 0)
        {
            string queryAttributes = "";
            for (int i = startCount; i < this.attributes.Count; i++)
            {
                string normalString = string.Concat(this.attributes[i].Name.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString()));
                string queryAttribute = normalString;
                if (this.attributes[i].PropertyType.IsClass && (this.attributes[i].PropertyType.Namespace == "System" && this.attributes[i].PropertyType.Name == "String") != true)
                {
                    queryAttribute += "_id";
                }
                queryAttributes += queryAttribute;
                if (i < this.attributes.Count - 1)
                {
                    queryAttributes += ",";
                }
            }
            return queryAttributes;
        }

        protected string getQueryAttributesNoPK()
        {
            return this.getQueryAttributes(1);
        }

        protected string getQueryValues(int startCount = 0)
        {
            string queryValues = "";
            for (int i = startCount; i < this.attributes.Count; i++)
            {
                object value = this.attributes[i].GetValue(this, null);
                string queryAttribute = this.attributes[i].Name;
                if (this.attributes[i].PropertyType.IsClass && (this.attributes[i].PropertyType.Namespace == "System" && this.attributes[i].PropertyType.Name == "String") != true)
                {
                    // Falls Attribut ist eine ERM-Klasse, dann nimm 1. Attribut und speichere den Wert für den Foreign Key.
                    if (value == null)
                    {
                        value = "NULL";
                    } else
                    {
                        Type attr_type = Type.GetType(this.attributes[i].PropertyType.FullName);
                        value = attr_type.GetProperties()[0].GetValue(value, null);
                    }
                }
                else if (this.attributes[i].PropertyType.Namespace == "System" && this.attributes[i].PropertyType.Name == "String")
                {
                    value = "'" + value + "'";
                }
                queryValues += value;
                if (i < this.attributes.Count - 1)
                {
                    queryValues += ",";
                }
            }
            return queryValues;
        }

        protected dynamic convert(DataRow row, bool isThis = false)
        {
            object obj = null;
            if (!isThis)
            {
                obj = Activator.CreateInstance(this.GetType());
            }
            for (int i = 0; i < row.ItemArray.Length; i++)
            {
                string attr_name = this.attributes[i].Name;
                object attr_value = row[i];
                PropertyInfo attr_info = this.attributes[i];
                Type attr_type = Type.GetType(this.attributes[i].PropertyType.FullName);

                if (Convert.IsDBNull(attr_value) == false)
                {
                    if (attr_type.IsValueType == false && attr_type.FullName.Contains("System.String") == false)
                    {
                        attr_value = Activator.CreateInstance(attr_type, attr_value);
                    }
                    if (isThis)
                    {
                        attr_info.SetValue(this, attr_value);
                    }
                    else
                    {
                        attr_info.SetValue(obj, attr_value);
                    }
                    
                }
            }
            return obj;
        }

        public string updateQuery()
        {
            string updateQuery = "UPDATE {0} \r\nSET {1} \r\nWHERE {2} = {3};";
            string[] splittedQueryAttributes = this.getQueryAttributes().Split(',');
            string[] splittedQueryValues = this.getQueryValues().Split(',');
            string finalset = "";
            for (int i = 1; i < splittedQueryAttributes.Length; i++)
            {
                finalset += "\r\n\t" + splittedQueryAttributes[i] + " = " + splittedQueryValues[i];
                if (i < splittedQueryAttributes.Length - 1)
                {
                    finalset += ",";
                }
            }
            string formattedUpdateQuery = string.Format(updateQuery, this.getTableName(), finalset, this.attributes[0].Name, this.attributes[0].GetValue(this, null));
            return formattedUpdateQuery;
        }

        public string deleteQuery()
        {
            string deleteQuery = "DELETE FROM {0} WHERE {1} = {2};";
            string formattedDeleteQuery = string.Format(deleteQuery, this.getTableName(), this.attributes[0].Name, this.attributes[0].GetValue(this, null));
            return formattedDeleteQuery;
        }

        public string insertQuery(object id = null)
        {
            string insertQuery = @"
INSERT INTO {0} ({1}) 
VALUES (
{2}
);";        string placeholder = "";
            string formattedInsertQuery = "";
            if (id == null)
            {
                for (int i = 1; i < this.attributes.Count; i++)
                {
                    placeholder += "\t\t'EMPTY'";
                    if (i < this.attributes.Count - 1)
                    {
                        placeholder += ",";
                    }
                    placeholder += "\r\n";
                }
                formattedInsertQuery = string.Format(insertQuery, this.getTableName(), this.getQueryAttributesNoPK(), placeholder);
            } 
            else
            {
                placeholder = "\t\t" + id;
                if (this.attributes.Count > 1)
                {
                    placeholder += ",";
                }
                placeholder += "\r\n";
                for (int i = 1; i < this.attributes.Count; i++)
                {
                    placeholder += "\t\t'EMPTY'";
                    if (i < this.attributes.Count - 1)
                    {
                        placeholder += ",";
                    }
                    placeholder += "\r\n";
                }
                formattedInsertQuery = string.Format(insertQuery, this.getTableName(), this.getQueryAttributes(), placeholder);
            }

            return formattedInsertQuery;
        }

        private object this[string name]
        {
            get
            {
                var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var property in properties)
                {
                    if (property.Name == name && property.CanRead)
                        return property.GetValue(this, null);
                }
                throw new ArgumentException("Can't find property");
            }
            set
            {
                var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var property in properties)
                {
                    if (property.Name == name && property.CanWrite)
                    { 
                        property.SetValue(this, value);
                        return;
                    }
                }
                throw new ArgumentException("Can't find property");
            }
        }
    }
}
