using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace GUI.Klassen
{
    public class ERMTable
    {
        private String tableName;
        private List<PropertyInfo> attributes = new List<PropertyInfo>();

        public ERMTable(object id)
        {
            // Get Plural name from data table. Ex: "Person" to "Persons"
            this.tableName = this.GetType().Name + "s";

            // Get all attributes
            foreach (PropertyInfo attribute in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (attribute.CanWrite & attribute.CanRead)
                {
                    this.attributes.Add(attribute);
                }
            }
            // Fetch row from datatable
            if (id != null)
            {
                string query = "SELECT TOP 1 {0} FROM {1} WHERE {2} = {3};";
                string formattedQuery = string.Format(query, this.getQueryAttributes(), this.tableName, this.attributes[0].Name, id);
                DataTable table = Program.sqlUser.select(formattedQuery);
                foreach (DataRow row in table.Rows)
                {
                    this.convert(row, true);
                }
            }
        }

        public List<object> selectAll(string condition = "")
        {
            /*
             * Gibt alle Objekten gemäss CONDITION-Klausel zurück und returniert eine Liste von Objekten
             */
            List<object> objectList = new List<object>();
            string query = "SELECT {0} FROM {1} {2};";
            string formattedQuery = string.Format(query, this.getQueryAttributes(), this.tableName, condition);
            DataTable table = Program.sqlUser.select(formattedQuery);
            foreach (DataRow row in table.Rows)
            {
                objectList.Add(this.convert(row));
            }
            return objectList;
        }

        protected string getQueryAttributes()
        {
            string queryAttributes = "";
            for (int i = 0; i < this.attributes.Count; i++)
            {
                string queryAttribute = this.attributes[i].Name;
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

        protected object convert(DataRow row, bool isThis = false)
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
