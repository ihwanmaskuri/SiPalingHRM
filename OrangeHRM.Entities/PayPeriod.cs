using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("hs_hr_payperiod")]
    public class PayPeriod
    {
        [Key]
        [Column("payperiod_code")]
        [StringLength(13)]
        public string Code { get; set; }

        [Column("payperiod_name")]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
