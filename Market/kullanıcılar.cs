namespace Market
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kullanıcılar
    {
        [Key]
        public int KullaniciId { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(10)]
        public string Sifre { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
