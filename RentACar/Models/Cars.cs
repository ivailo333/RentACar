using System.ComponentModel.DataAnnotations;


namespace RentACar.Models
{
    public class Cars
    {
        [Key]
        public int CarId { get; set; }
        public string Marka { get; set; }
        public string RegNumber { get; set; }
        public int ClientId { get; set; }
        public DateTime RentCar { get; set; }
        public int Km { get; set; }
        public int EmployeeId { get; set; }
        public decimal Price { get; set; }

    }
}
