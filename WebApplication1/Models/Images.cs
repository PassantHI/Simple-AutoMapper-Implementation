using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Images
    {
        [Key]
        public int ImageId { get; set; }
        [Required]
        public string URL { get; set; }

        [ForeignKey("Room")]
        public int RoomID {  get; set; }
        public Room Room { get; set; }

    }
}
