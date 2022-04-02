using System.ComponentModel.DataAnnotations;


namespace RentACar.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }

    }
}
