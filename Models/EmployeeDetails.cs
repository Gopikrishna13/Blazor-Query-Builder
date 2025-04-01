using System.ComponentModel.DataAnnotations;

namespace CreatingQueryBuilderSample.Models
{
    public class EmployeeDetails
    {

        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int Salary { get; set; }
    }
}
