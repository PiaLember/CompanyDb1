using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CompanyDb.Models
{
    public class SickLeave
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SickLeaveId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public required DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }
    }
}