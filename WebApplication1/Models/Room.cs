using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Utality;

namespace WebApplication1.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        [Required]
        public string RoomDescribtion { get; set; }
        [Required]
        public string RoomTitle { get; set; }
        public string RoomAddress { get; set; }
        [Required]
        public string RoomOwner { get; set; }
        public string RoomOwnerID { get; set; }

        public required string City {  get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public int Price {  get; set; }
        public int Rating { get; set; }
        [Required]
        public RoomType RoomType { get; set; }
        [Required]
        //public int CountDays {  get; set; }
        public bool IsActive { get; set; } //status

        public IList<Images> Images { get; set; }=new List<Images>();
        public IList<RoomBookingDetails> RoomBookingDetails { get; set; } =new List<RoomBookingDetails>();

    }
    
}
