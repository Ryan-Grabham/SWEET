using System.ComponentModel.DataAnnotations;

namespace SWEET.Models
{
    public class AssetModel
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
