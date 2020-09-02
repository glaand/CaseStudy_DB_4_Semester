using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace GUI.Tabellen
{
    public partial class CustomMarktverwaltungssystemContext : MarktverwaltungssystemContext
    {
        public string username;
        private string password;
        public string ipaddress;

        public CustomMarktverwaltungssystemContext() : base() { }
        public CustomMarktverwaltungssystemContext(string username, string password, string ipaddress) : base()
        {
            this.username = username;
            this.password = password;
            this.ipaddress = ipaddress;
        }

        public CustomMarktverwaltungssystemContext(DbContextOptions<MarktverwaltungssystemContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=" + this.ipaddress + ";Database=Marktverwaltungssystem;User ID=" + this.username + ";Password=" + this.password + ";Trusted_Connection=True;Integrated Security=False");
            }
        }
    }
}
