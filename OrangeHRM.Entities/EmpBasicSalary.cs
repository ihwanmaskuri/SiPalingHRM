using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("hs_hr_emp_basicsalary")]
    public class EmpBasicSalary
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("emp_number")]
        public int EmployeeNumber { get; set; }

        [ForeignKey("EmployeeNumber")]
        public virtual Employee Employee { get; set; }

        [Column("currency_id")]
        [StringLength(3)]
        public string CurrencyId { get; set; }

        [Column("ebsal_basic_salary")]
        public decimal BasicSalary { get; set; }

        [Column("payperiod_code")]
        [StringLength(13)]
        public string PayPeriodCode { get; set; }

        [Column("salary_component")]
        [StringLength(100)]
        public string SalaryComponent { get; set; }

        [Column("comments")]
        [StringLength(255)]
        public string Comments { get; set; }
    }
}
