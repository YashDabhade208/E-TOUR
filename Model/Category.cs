using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTour.Model
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Category_Id { get; set; }
        public String? Category_Name { get; set; }

        public ICollection<SubCategory>? SubCategories { get; set; }
    }
}
