using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concreate
{
    public class Testimonial
    {
        [Key]
        public int ID { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; }
        public string CommentImage { get; set; }
        public bool Status { get; set; }
    }
}