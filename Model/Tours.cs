using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eTour.Model
{
    public class Tours
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Tour_Id { get; set; }

        public String? Tour_Name { get; set; }

        public int Duration { get; set; }

        public int SubCategory_Id {  get; set; }
        [ForeignKey("SubCategory_Id")]
        public SubCategory? Subcategory { get; set; }

        public ICollection<Iternery>? Iterneries { get; set; }
        public ICollection<TourDate>? Dates { get; set; }
        
    }
}