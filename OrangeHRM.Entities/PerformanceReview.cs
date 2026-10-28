using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("ohrm_performance_review")]
    public class PerformanceReview
    {
        [Key]
        public int Id { get; set; }

        [Column("employee_number")]
        public int EmployeeNumber { get; set; }

        [ForeignKey("EmployeeNumber")]
        public virtual Employee Employee { get; set; }

        public DateTime WorkPeriodStart { get; set; }
        public DateTime WorkPeriodEnd { get; set; }
        public DateTime DueDate { get; set; }

        public short Status { get; set; } // 1: Activated, 2: Approved, 3: Completed
    }
}
