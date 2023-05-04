using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kullanici_Giris_Ekrani.Models
{
    public partial class KullaniciKayitDBContext : DbContext
    {
        public KullaniciKayitDBContext()
        {
        }

        public KullaniciKayitDBContext(DbContextOptions<KullaniciKayitDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KullaniciBilgileri> KullaniciBilgileris { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=KullaniciKayitDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KullaniciBilgileri>(entity =>
            {
                entity.HasKey(e => e.KullaniciId)
                    .HasName("PK__Kullanic__E011F09BCA7C2CEB");

                entity.ToTable("KullaniciBilgileri");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.KullaniciMail).HasMaxLength(200);

                entity.Property(e => e.KullaniciSifre).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
