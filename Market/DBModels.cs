namespace Market
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModels : DbContext
    {
        public DBModels()
            : base("name=DBModels")
        {
        }

        public virtual DbSet<kullanıcılar> kullanıcılar { get; set; }
        public virtual DbSet<musteriler> musteriler { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tedarikciler> tedarikciler { get; set; }
        public virtual DbSet<urunler> urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<kullanıcılar>()
                .Property(e => e.KullaniciAdi)
                .IsFixedLength();

            modelBuilder.Entity<kullanıcılar>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<musteriler>()
                .Property(e => e.MusteriAd)
                .IsFixedLength();

            modelBuilder.Entity<musteriler>()
                .Property(e => e.MusteriSoyad)
                .IsFixedLength();

            modelBuilder.Entity<tedarikciler>()
                .Property(e => e.TedarikciAdi)
                .IsFixedLength();

            modelBuilder.Entity<urunler>()
                .Property(e => e.UrunAdi)
                .IsFixedLength();
        }
    }
}
