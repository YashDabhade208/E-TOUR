using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTour.Model
{
    public class TourDate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Tourdate_Id { get; set; }
        public string Validfrom { get; set; }
        public string Validto { get; set; }

        [ForeignKey("Tours")]
        public int Tour_Id {  get; set; }
        public Tours Tours { get; set; }

    }
}