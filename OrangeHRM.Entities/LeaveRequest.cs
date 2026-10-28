using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("ohrm_leave_request")]
    public class LeaveRequest
    {
        [Key]
        public int Id { get; set; }

        [Column("leave_type_id")]
        public int LeaveTypeId { get; set; }

        [ForeignKey("LeaveTypeId")]
        public virtual LeaveType LeaveType { get; set; }

        [Column("emp_number")]
        public int EmployeeNumber { get; set; }

        [ForeignKey("EmployeeNumber")]
        public virtual Employee Employee { get; set; }

        public DateTime DateApplied { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        public virtual ICollection<Leave> LeaveDays { get; set; }
    }

    [Table("ohrm_leave")]
    public class Leave
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Column("length_hours")]
        public decimal LengthHours { get; set; }

        [Column("length_days")]
        public decimal LengthDays { get; set; }

        public short Status { get; set; } // 1: Pending, 2: Approved, 3: Rejected, etc.

        [Column("leave_request_id")]
        public int LeaveRequestId { get; set; }

        [ForeignKey("LeaveRequestId")]
        public virtual LeaveRequest LeaveRequest { get; set; }
    }
}
