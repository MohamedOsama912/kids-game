using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace kids_game_app.data
{
    internal class dbconnection : DbContext
    {
        public DbSet<user> users { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace the connection string with your actual SQL Server connection string
            optionsBuilder.UseSqlServer("Data Source=MOHAMEDOSAMA;Initial Catalog=kids_game_app;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

    }
}
