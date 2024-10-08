using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        protected IRoomRepository roomRepository;

        public RoomsController(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetAll() 
        {
            var Rooms = await roomRepository.GetListAsync(a=>a.RoomID==1);
            if (Rooms!=null || Rooms.Any()) 
            {
                return Ok(Rooms);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RoomDTO>> GetById(int id) 
        {
            var room= await roomRepository.GetByIdAsync(id);
            if (room!=null) return Ok(room);
            return NotFound();
        
        }








    }
}
