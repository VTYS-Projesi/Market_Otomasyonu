namespace Market.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tedarikciler")]
    public partial class Tedarikciler
    {
        [Key]
        public int TedarikciId { get; set; }

        public int? BorcId { get; set; }

        [StringLength(50)]
        public string TedarikciAdi { get; set; }

        [ForeignKey("BorcId")]
        public virtual Borc Borc { get; set; }
    }
}
