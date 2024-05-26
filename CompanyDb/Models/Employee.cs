using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CompanyDb.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [StringLength(20)]
        public required string FirstName { get; set; }

        [StringLength(20)]
        public required string LastName { get; set; }

        public int PersonalIdentificationNumber { get; set; }

        [StringLength(100)]
        public string? ContactAddress { get; set; }

        public int ContactPhoneNumber { get; set; }

        [StringLength(30)]
        public string? ContactEmail { get; set; }

        public DateTime AtWorkSince { get; set; }

        public DateTime? AtWorkUntil { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }

        [StringLength(100)]
        public string? Comment { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public required Department Department { get; set; }
        [ForeignKey("JobTitle")]
        public int JobTitleId { get; set; }

        public JobTitle JobTitle { get; set; }
    }
}