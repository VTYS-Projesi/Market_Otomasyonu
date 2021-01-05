namespace Market
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tedarikciler")]
    public partial class tedarikciler
    {
        [Key]
        public int TedarikciId { get; set; }

        [StringLength(50)]
        public string TedarikciAdi { get; set; }
    }
}
