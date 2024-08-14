using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eTour.Model
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Customer_Id { get; set; }

        public string Customer_FirstName {  get; set; }
        public string Customer_LastName { get; set; }
        public string Customer_MobNo {  get; set; }
        public string Customer_EmailId { get; set; }
        public string Customer_Password { get; set; }
        public int Customer_age { get; set; }
        public string Customer_gender{ get; set;}
        public string Customer_Dateofbirth { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_City { get; set; }
        public string Customer_State {  get; set; }
       
        public string Customer_Pincode { get; set; }

        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
    }
}