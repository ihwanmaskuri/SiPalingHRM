using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("hs_hr_location")]
    public class Location
    {
        [Key]
        [Column("location_id")]
        public int Id { get; set; }

        [Required]
        [StringLength(110)]
        public string Name { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [Column("country_code")]
        [StringLength(3)]
        public string CountryCode { get; set; }
    }
}
