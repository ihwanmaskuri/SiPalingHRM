using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("ohrm_leave_type")]
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}
