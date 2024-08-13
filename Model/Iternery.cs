using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eTour.Model
{
    public class Iternery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Iternery_Id {  get; set; }

        public String? Description { get; set; }


        public int Tour_Id { get; set; }
        [ForeignKey("Tour_Id")]
        public Tours? Tours { get; set; }

    }
}