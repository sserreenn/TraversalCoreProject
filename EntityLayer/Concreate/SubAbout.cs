using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class SubAbout
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public bool Status { get; set; } 
    }
}