using System.ComponentModel.DataAnnotations;

namespace SantaNaughtyNiceData.Models
{
    public class Children
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public int House_Number { get; set; }
        [Required]
        [MaxLength(50)]
        public string StreetName { get; set; }
        [Required]
        [MaxLength(50)]
        public string CityName { get; set; }
        [Required]
        [MaxLength(100)]
        public string PostalCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; }
        [Required]
        public int Yearly_ANNS { get; set; }
        [Required]
        public int Historical_ANNS { get; set; }
        public List<ChildsHistory> ChildHistory { get; set; }

    }
}
