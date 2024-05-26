using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CompanyDb.Models
{
    public class Vacation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VacationId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public required DateTime StartDate { get; set; }

        public required DateTime EndDate { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }
    }
}