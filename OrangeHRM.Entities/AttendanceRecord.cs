using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("ohrm_attendance_record")]
    public class AttendanceRecord
    {
        [Key]
        public long Id { get; set; }

        [Column("employee_id")]
        public int EmployeeNumber { get; set; }

        [ForeignKey("EmployeeNumber")]
        public virtual Employee Employee { get; set; }

        public DateTime? PunchInUtcTime { get; set; }
        public string PunchInNote { get; set; }
        public DateTime? PunchOutUtcTime { get; set; }
        public string PunchOutNote { get; set; }

        [StringLength(255)]
        public string State { get; set; } // PUNCHED IN, PUNCHED OUT
    }
}
