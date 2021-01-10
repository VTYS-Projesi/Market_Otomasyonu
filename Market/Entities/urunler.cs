namespace Market.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Urunler")]
    public partial class Urunler
    {
        [Key]
        public int UrunKodu { get; set; }

        [Required]
        [StringLength(50)]
        public string UrunAdi { get; set; }

        public int BarkodNo { get; set; }

        public double AlisFiyat { get; set; }

        public double SatisFiyat { get; set; }

        public int Miktar { get; set; }

        public int İrsaliyeNo { get; set; }

        [ForeignKey("İrsaliyeNo")]
        public virtual Irsaliye Irsaliye { get; set; }

    }
}