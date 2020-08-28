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

        public CustomMarktverwaltungssystemContext() : base() { }
        public CustomMarktverwaltungssystemContext(string username, string password) : base()
        {
            this.username = username;
            this.password = password;
        }

        public CustomMarktverwaltungssystemContext(DbContextOptions<MarktverwaltungssystemContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=34.65.73.57;Database=Marktverwaltungssystem;User ID=" + this.username + ";Password=" + this.password + ";Trusted_Connection=True;Integrated Security=False");
            }
        }
    }
}
