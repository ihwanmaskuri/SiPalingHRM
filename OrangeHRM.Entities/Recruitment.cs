using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrangeHRM.Entities
{
    [Table("ohrm_job_vacancy")]
    public class JobVacancy
    {
        [Key]
        public int Id { get; set; }

        [Column("job_title_code")]
        public int JobTitleId { get; set; }

        [ForeignKey("JobTitleId")]
        public virtual JobTitle JobTitle { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Column("no_of_positions")]
        public int NumberOfPositions { get; set; }

        public bool Status { get; set; } // Active / Closed
        
        public DateTime DefinedTime { get; set; }
    }

    [Table("ohrm_job_candidate")]
    public class JobCandidate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [Column("last_name")]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(30)]
        public string ContactNumber { get; set; }

        public short Status { get; set; } // Application Initiated, Shortlisted, Interviewed, Hired, Rejected
        
        public DateTime DateOfApplication { get; set; }
    }
}
