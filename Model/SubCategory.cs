using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTour.Model
{
    public class SubCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Subcategory_Id { get; set; }

        public String? Subcategory_Name { get; set; }

        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public Category? Category { get; set; }

        public ICollection<Tours>? Tours { get; set; }
    }
}
