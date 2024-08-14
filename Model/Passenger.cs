using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eTour.Model
{
    public class Passenger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Passenger_Id { get; set; }

        public string Passenger_Name { get; set; }
        public string Passenger_MobNo { get; set; }
        public string Passenger_EmailId { get; set; }
        public string Passenger_Gender {  get; set; }

        [ForeignKey("Booking")]
        public int Booking_Id { get; set; }
        public Booking? Booking { get; set; }
    }
}