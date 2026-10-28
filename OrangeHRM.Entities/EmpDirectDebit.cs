using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("hs_hr_emp_directdebit")]
    public class EmpDirectDebit
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("salary_id")]
        public int SalaryId { get; set; }

        [ForeignKey("SalaryId")]
        public virtual EmpBasicSalary BasicSalaryInfo { get; set; }

        [Column("dd_routing_num")]
        public int RoutingNumber { get; set; }

        [Column("dd_account")]
        [StringLength(100)]
        public string AccountNumber { get; set; }

        [Column("dd_amount")]
        public decimal Amount { get; set; }

        [Column("dd_account_type")]
        [StringLength(20)]
        public string AccountType { get; set; } // CHECKING, SAVINGS

        [Column("dd_transaction_type")]
        [StringLength(20)]
        public string TransactionType { get; set; } // BLANK, PERC, FLAT, FLATMINUS
    }
}
