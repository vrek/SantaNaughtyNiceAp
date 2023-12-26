using System.ComponentModel.DataAnnotations;

namespace SantaNaughtyNiceData.Models
{
    public class Activities
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Value { get; set; }
    }
}
