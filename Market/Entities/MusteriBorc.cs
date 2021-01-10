namespace Market.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class MusteriBorc
    {
        [Key]
        public int BorcId { get; set; }

        public int MusteriId { get; set; }

        public string Borc { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }

        [ForeignKey("MusteriId")]
        public virtual Musteriler Musteri { get; set; }
    }
}
