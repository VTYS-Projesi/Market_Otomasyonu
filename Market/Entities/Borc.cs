namespace Market.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Borc
    {
        [Key]
        public int TedarikciId { get; set; }

        public int KullaniciId { get; set; }

        public int Odeme { get; set; }

        [Column(TypeName = "date")]
        public DateTime Tarih { get; set; }
    }
}
