namespace Market.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Irsaliye
    {
        [Key]
        public int IrsaliyeNo { get; set; }

        public string BirimFiyati { get; set; }

    }
}
