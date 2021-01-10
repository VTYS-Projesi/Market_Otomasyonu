namespace Market.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class UrunStok
    {
        [Key]
        public int StokId { get; set; }

        public int Miktar { get; set; }

        public int UrunKodu { get; set; }

        [ForeignKey("UrunKodu")]
        public virtual Urunler Urun { get; set; }
    }
}