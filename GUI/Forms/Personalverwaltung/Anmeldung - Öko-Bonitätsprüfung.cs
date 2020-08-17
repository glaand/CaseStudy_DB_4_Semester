using GUI.Tabellen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Forms.Personalverwaltung
{
    public partial class Anmeldung___Öko_Bonitätsprüfung : Form
    {
        Persons person;
        public Anmeldung___Öko_Bonitätsprüfung(Persons person)
        {
            this.person = person;
            InitializeComponent();
        }
    }
}
