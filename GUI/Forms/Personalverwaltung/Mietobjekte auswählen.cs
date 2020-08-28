using GUI.Tabellen;
using System;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace GUI.Forms.Personalverwaltung
{

    public partial class Mietobjekte_auswählen : Form
    {
        private Areas area;
        private Sellers seller;
        List<RentalProperties> rentalProperties;
        private List<RPRectangle> rPRectangles = new List<RPRectangle>();
        private RPRectangle? selectedRp;
        private RentalProperties savedRp;

        public Mietobjekte_auswählen(Areas area, Sellers seller)
        {
            this.area = area;
            this.seller = seller;
            this.rentalProperties = Program.db.RentalProperties
                .Where(r => r.Area == this.area)
                .Include(r => r.RentalPropertyReservations).ToList();
            InitializeComponent();
        }

        private void Mietobjekte_auswählen_Load(object sender, EventArgs e)
        {
            this.lblArea.Text = "Areal: " + this.area.Address.Place.Place + ", " + this.area.AdditionalInfo;

            prepareSquares();
        }

        private void prepareSquares()
        {
            int startX = 0;
            int startY = 0;
            int x = startX;
            int y = startY;
            int totalProperties = this.rentalProperties.Count;
            int xCount = Convert.ToInt32(Math.Ceiling(Math.Sqrt(totalProperties)));
            int currentXCount = 1;

            int width = Convert.ToInt32(Math.Ceiling((decimal)(this.drawPanel.Width / xCount + 1) - 5));
            int height = width;

            foreach (RentalProperties rp in this.rentalProperties)
            {
                Color clr = Color.DarkGreen;

                if (rp.RentalPropertyReservations.Count > 0)
                {
                    clr = Color.Red;
                }

                foreach (RentalPropertyReservations reservation in this.seller.RentalPropertyReservations)
                {
                    if (reservation.Seller == this.seller && reservation.RentalProperty == rp)
                    {
                        clr = Color.RoyalBlue;
                        this.savedRp = rp;
                    }
                }

                RPRectangle obj = new RPRectangle
                {
                    rectangle = new Rectangle(x, y, width, height),
                    property = rp,
                    color = clr
                };

                this.rPRectangles.Add(obj);

                currentXCount++;
                if (currentXCount > xCount)
                {
                    x = startX;
                    y += (height + 5);
                    currentXCount = 1;
                }
                else
                {
                    x += width + 5;
                }
            }
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (RPRectangle rp in this.rPRectangles)
            {
                e.Graphics.FillRectangle(new SolidBrush(rp.color), rp.rectangle);
            }
        }

        private void enableCheck()
        {
            this.lblRentalProperty.Text = "Mietobjekt: ID " + this.selectedRp.property.RentalPropertyId.ToString();
            this.btnAssign.Enabled = true;
        }

        private void disableCheck()
        {
            this.selectedRp = null;
            this.lblRentalProperty.Text = "Mietobjekt: -- Leer --";
            this.btnAssign.Enabled = false;
        }

        private void drawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            bool isEnabled = false;
            foreach (RPRectangle rp in this.rPRectangles)
            {
                Color newColor = rp.color;
                if (rp.rectangle.Contains(e.Location))
                {
                    if (rp.color != Color.Red)
                    {
                        if (rp.color != Color.Yellow)
                        {
                            newColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dieses Mietobjekt wurde bereits vergeben.");
                    }
                }
                else
                {
                    if (rp.color != Color.Red)
                    {
                        if (rp.color == Color.Yellow)
                        {
                            newColor = Color.DarkGreen;
                        }
                    }
                }

                rp.color = newColor;
                if (newColor == Color.Yellow)
                {
                    this.selectedRp = rp;
                    enableCheck();
                    isEnabled = true;
                }
            }
            if (isEnabled == false)
            {
                disableCheck();
            }
            drawPanel.Invalidate();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var obj = new RentalPropertyReservations
            {
                Seller = this.seller,
                RentalProperty = this.selectedRp.property
            };
            Program.db.Database.BeginTransaction();
            try
            {
                if (this.savedRp != null)
                {
                    Program.db.RentalPropertyReservations
                        .RemoveRange(Program.db.RentalPropertyReservations.Where(r => r.Seller == this.seller && r.RentalProperty == this.savedRp));
                }

                Program.db.RentalPropertyReservations.Add(obj);
                Program.db.SaveChanges();
                Program.db.Database.CommitTransaction();
            }
            catch (Exception ex)
            {
                Program.db.Database.RollbackTransaction();
                MessageBox.Show("Ein Fehler ist aufgetreten.");
            }
            this.Close();
        }
    }
    class RPRectangle
    {
        // Komposition, da die Klasse Rectangle versiegelt ist.
        public Rectangle rectangle { get; set; }
        public RentalProperties property { get; set; }
        public Color color { get; set; }
    }
}
