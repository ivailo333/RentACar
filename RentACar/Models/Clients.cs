using System.ComponentModel.DataAnnotations;


namespace RentACar.Models
{
    public class Clients
    {
        [Key]
        public int ClientId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
