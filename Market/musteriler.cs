namespace Market
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("musteriler")]
    public partial class musteriler
    {
        [Key]
        public int MusteriId { get; set; }

        [StringLength(50)]
        public string MusteriAd { get; set; }

        [StringLength(50)]
        public string MusteriSoyad { get; set; }

        public int? MusteriTelNo { get; set; }

        public int? Borc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Tarih { get; set; }
    }
}
