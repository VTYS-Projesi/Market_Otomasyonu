namespace Market
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("urunler")]
    public partial class urunler
    {
        [Key]
        public int UrunId { get; set; }

        [Required]
        [StringLength(50)]
        public string UrunAdi { get; set; }

        public int BarkodNo { get; set; }

        public double AlisFiyat { get; set; }

        public double SatisFiyat { get; set; }

        public int UrunAdet { get; set; }

        public int İrsaliyeNo { get; set; }
    }
}
