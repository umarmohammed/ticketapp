using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TicketApp.Schema.Model
{
    public partial class Entities : DbContext
    {
        public Entities()
        {
        }

        public Entities(DbContextOptions<Entities> options)
            : base(options)
        {
        }

        public virtual DbSet<BusRoute> BusRoute { get; set; }
        public virtual DbSet<Databasechangeloglock> Databasechangeloglock { get; set; }

        // Unable to generate entity type for table 'dbo.DATABASECHANGELOG'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NCS013F\\SQLEXPRESS;Database=TicketApp_db;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusRoute>(entity =>
            {
                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Databasechangeloglock>(entity =>
            {
                entity.ToTable("DATABASECHANGELOGLOCK");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Locked).HasColumnName("LOCKED");

                entity.Property(e => e.Lockedby)
                    .HasColumnName("LOCKEDBY")
                    .HasMaxLength(255);

                entity.Property(e => e.Lockgranted)
                    .HasColumnName("LOCKGRANTED")
                    .HasColumnType("datetime2(3)");
            });
        }
    }
}
