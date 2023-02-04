using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebFrogs.Models.Entities
{
    [Table("Toads")]
    public class Toad
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string shortDesc { get; set; }

        [Required]
        public string fullDesc { get; set; }

        [Required]
        public string mainImg { get; set; }
    }
}
