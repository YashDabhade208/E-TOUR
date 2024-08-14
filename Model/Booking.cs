using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eTour.Model
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Booking_Id { get; set; }

        public string Booking_Date {  get; set; }

        [ForeignKey("Customer")]
        public int Customer_Id {  get; set; }
        public Customer? Customer {  get; set; }
        public ICollection<Passenger>? Passsengers {  get; set; }
    }
}
