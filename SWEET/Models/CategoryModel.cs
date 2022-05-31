using System.ComponentModel.DataAnnotations;

namespace SWEET.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

       
        [Display(Name = "Category Name")]
        
        public string? Name { get; set; }
    }
}
