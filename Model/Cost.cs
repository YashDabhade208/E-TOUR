using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTour.Model
{
    public class Cost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cost_id { get; set; }
        public int Tour_Cost {  get; set; }
        public int Childwithbed {  get; set; }
        public int Childwithoutbed {  get; set; }

        public int Tour_Id { get; set; }

        [ForeignKey("Tour_Id")]
        public Tours? Tours { get; set; }
    }
}
