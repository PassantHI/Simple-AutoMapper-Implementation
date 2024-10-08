using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Models;
using WebApplication1.Utality;


namespace WebApplication1.DTOs
{
    public class RoomDTO
    {
        public string RoomDescribtion { get; set; }
        [Required]
        public string RoomTitle { get; set; }
        public string RoomAddress { get; set; }
        [Required]
        public string RoomOwner { get; set; }
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public int Price { get; set; }
        public int Rating { get; set; }
        [Required]
        public RoomType RoomType { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public IList<RoomImagesDTO> Images { get; set; } = new List<RoomImagesDTO>();


    }

    


    public class RoomImagesDTO
    {
       public string URL { get; set; }

    }
}
