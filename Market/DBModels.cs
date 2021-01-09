namespace Market
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Market.Entities;

    public partial class DBModels : DbContext
    {
        public DBModels()
            : base("name=DBModels")
        {
        }

        public virtual DbSet<Kullanicilar> Kullanıcılar { get; set; }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tedarikciler> Tedarikciler { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Irsaliye> Irsaliyeler { get; set; }
        public virtual DbSet<Borc> Borclar { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.KullaniciAdi)
                .IsFixedLength();

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Musteriler>()
                .Property(e => e.MusteriAd)
                .IsFixedLength();

            modelBuilder.Entity<Musteriler>()
                .Property(e => e.MusteriSoyad)
                .IsFixedLength();

            modelBuilder.Entity<Tedarikciler>()
                .Property(e => e.TedarikciAdi)
                .IsFixedLength();

            modelBuilder.Entity<Urunler>()
                .Property(e => e.UrunAdi)
                .IsFixedLength();
        }
    }
}
