using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CompanyDb.Models
{
    public class WorkTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkTimeId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("JobTitle")]
        public int JobTitleId { get; set; }

        public required DateTime StartingDate { get; set; }

        public DateTime? EndingDate { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }
        
        public ICollection<JobTitle>? JobTitles { get; set; }

    }
}