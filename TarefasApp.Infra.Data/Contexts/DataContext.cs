using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Infra.Data.Mappings;

namespace TarefasApp.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL1001.site4now.net;Initial Catalog=db_ab6aab_tarefasapp;User Id=db_ab6aab_tarefasapp_admin;Password=@Admin123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration(new TarefaMap());
        }
    }
}
