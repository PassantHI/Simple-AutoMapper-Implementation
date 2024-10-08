using AutoMapper;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Room, RoomDTO>().ReverseMap();
            CreateMap<Images,RoomImagesDTO>().ReverseMap();
        }


    }
}
