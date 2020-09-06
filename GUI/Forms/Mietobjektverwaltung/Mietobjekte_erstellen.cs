using GUI.Forms.Allgemein;
using GUI.Tabellen;
using System;
using System.Windows.Forms;

namespace GUI.Forms.Arealverwaltung
{
    public partial class Mietobjekte_erstellen : Form
    {
        private Areas area;
        public Mietobjekte_erstellen(Areas area)
        {
            this.area = area;
            InitializeComponent();
        }

        private void Mietobjekte_erstellen_Load(object sender, EventArgs e)
        {
            this.numericUpDown1.Minimum = 10;
            this.numericUpDown1.Maximum = this.area.Square;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.db.Database.BeginTransaction();
            try
            {
                int countProperties = (int)Math.Floor(this.area.Square / this.numericUpDown1.Value);
                for (int i = 0; i < countProperties; i++)
                {
                    var rentalProperty = new RentalProperties
                    {
                        AreaId = this.area.AreaId,
                        Square = this.numericUpDown1.Value
                    };
                    Program.db.RentalProperties.Add(rentalProperty);
                }
                MessageBox.Show(countProperties.ToString() + " neue Mietobjekte wurden erstellt.");
                Program.db.SaveChanges();
                Program.db.Database.CommitTransaction();
            }
            catch (Exception ex)
            {
                Program.db.Database.RollbackTransaction();
                if (ex.InnerException.Message.Contains("permission was denied"))
                {
                    MessageBox.Show("Du hast keine Berechtigungen dafür.");
                }
                else
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten.");
                }
            }
        }
    }
}
