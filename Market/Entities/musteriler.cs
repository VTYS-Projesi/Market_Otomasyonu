namespace Market.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Musteriler")]
    public partial class Musteriler
    {
        [Key]
        public int MusteriId { get; set; }

        [StringLength(50)]
        public string MusteriAd { get; set; }

        [StringLength(50)]
        public string MusteriSoyad { get; set; }

        [StringLength(50)]
        public string MusteriTelNo { get; set; }

    }
}
