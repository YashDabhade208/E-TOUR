using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eTour.Model
{
    public class Payment
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Payment_Id { get; set; }
        public string Total_Cost {  get; set; }
        public string Payment_Status { get; set; }

        [ForeignKey("Booking_Id")]
        public int Booking_Id {  get; set; }
        public Booking? Booking {  get; set; }

    }
}
