using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class NewsLetter
    {
        [Key]
        public int ID { get; set; }
        public string Mail { get; set; }
    }
}