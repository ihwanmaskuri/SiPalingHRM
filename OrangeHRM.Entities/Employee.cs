using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("hs_hr_employee")]
    public class Employee
    {
        [Key]
        [Column("emp_number")]
        public int EmployeeNumber { get; set; }

        [Column("employee_id")]
        [StringLength(50)]
        public string EmployeeId { get; set; }

        [Required]
        [Column("emp_lastname")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [Column("emp_firstname")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Column("emp_middle_name")]
        [StringLength(100)]
        public string MiddleName { get; set; }

        [Column("emp_birthday")]
        public DateTime? Birthday { get; set; }

        [Column("emp_gender")]
        public short? Gender { get; set; }

        [Column("joined_date")]
        public DateTime? JoinedDate { get; set; }

        [Column("emp_work_email")]
        [StringLength(50)]
        public string WorkEmail { get; set; }
    }
}
