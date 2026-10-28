using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("ohrm_job_title")]
    public class JobTitle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("job_title")]
        [StringLength(100)]
        public string Title { get; set; }

        [Column("job_description")]
        [StringLength(400)]
        public string Description { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}
