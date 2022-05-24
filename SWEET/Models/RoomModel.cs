using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWEET.Models
{
    public class RoomModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        [NotMapped]
        public List<AssetModel> Assets { get; set; }
    }
}
