using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("hs_hr_currency_type")]
    public class CurrencyType
    {
        [Key]
        [Column("code")]
        public int Code { get; set; }

        [Required]
        [Column("currency_id")]
        [StringLength(3)]
        public string CurrencyId { get; set; }

        [Required]
        [Column("currency_name")]
        [StringLength(70)]
        public string CurrencyName { get; set; }
    }
}
