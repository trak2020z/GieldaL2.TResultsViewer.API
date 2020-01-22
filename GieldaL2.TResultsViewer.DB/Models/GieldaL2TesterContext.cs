using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GieldaL2.TResultsViewer.DB.Models
{
    public partial class GieldaL2TesterContext : DbContext
    {
        public GieldaL2TesterContext(DbContextOptions<GieldaL2TesterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GeneratorLog> GeneratorLog { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GeneratorLog>(entity =>
            {
                entity.ToTable("generator_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActiveClientsQuantity).HasColumnName("active_clients_quantity");

                entity.Property(e => e.BackendTime).HasColumnName("backend_time");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DbDeletesQuantity).HasColumnName("db_deletes_quantity");

                entity.Property(e => e.DbDeletesTime).HasColumnName("db_deletes_time");

                entity.Property(e => e.DbInsertsQuantity).HasColumnName("db_inserts_quantity");

                entity.Property(e => e.DbInsertsTime).HasColumnName("db_inserts_time");

                entity.Property(e => e.DbSelectsQuantity).HasColumnName("db_selects_quantity");

                entity.Property(e => e.DbSelectsTime).HasColumnName("db_selects_time");

                entity.Property(e => e.DbUpdatesQuantity).HasColumnName("db_updates_quantity");

                entity.Property(e => e.DbUpdatesTime).HasColumnName("db_updates_time");

                entity.Property(e => e.ReqNo).HasColumnName("req_no");

                entity.Property(e => e.ReqTime).HasColumnName("req_time");

                entity.Property(e => e.ReqType)
                    .IsRequired()
                    .HasColumnName("req_type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.RespType)
                    .IsRequired()
                    .HasColumnName("resp_type")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.TestStartTime).HasColumnName("test_start_time");

                entity.Property(e => e.TestType)
                    .IsRequired()
                    .HasColumnName("test_type")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });
        }
    }
}
