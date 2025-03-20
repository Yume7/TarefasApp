using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Models;

namespace TarefasApp.Infra.Data.Mappings
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("TAREFA");
            
            builder.HasKey(t => t.Id);
            
            builder.Property(t => t.Id)
                .HasColumnName("ID");
            
            builder.Property(t => t.Titulo)
                .HasColumnName("TITULO")
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(t => t.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(300)
                .IsRequired();
            
            builder.Property(t => t.Status)
                .HasColumnName("STATUS")
                .IsRequired();

            builder.Property(t => t.Data)
                .HasColumnName("DATA")
                .IsRequired();

        }
    }
}
