using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class Guide
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterURL { get; set; }
        public string InstagramURL { get; set; }
        public bool status { get; set; }
    }
}