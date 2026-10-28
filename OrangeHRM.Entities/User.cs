using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("ohrm_user")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string UserPassword { get; set; }

        [Column("emp_number")]
        public int? EmployeeNumber { get; set; }

        [ForeignKey("EmployeeNumber")]
        public virtual Employee Employee { get; set; }

        public bool IsDeleted { get; set; }
    }
}
