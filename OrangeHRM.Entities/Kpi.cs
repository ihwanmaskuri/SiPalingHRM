using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("ohrm_kpi")]
    public class Kpi
    {
        [Key]
        public int Id { get; set; }

        [Column("job_title_code")]
        public int JobTitleId { get; set; }

        [ForeignKey("JobTitleId")]
        public virtual JobTitle JobTitle { get; set; }

        [Required]
        [Column("kpi_indicators")]
        [StringLength(255)]
        public string Indicators { get; set; }

        [Column("min_rating")]
        public int MinRating { get; set; }

        [Column("max_rating")]
        public int MaxRating { get; set; }

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}
