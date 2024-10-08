using System.Linq.Expressions;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IRoomRepository 
    {
        Task<RoomDTO> GetByIdAsync(int id);
        
        Task< IEnumerable<RoomDTO>> GetListAsync(Expression<Func<Room, bool>>? expression=null);

        Task<RoomDTO> GetBy(Expression<Func<RoomDTO, bool>> expression, string include);

        Task<IEnumerable<RoomDTO>> FilterRooms(string country, int roomType);

        Task<bool>SaveAllAsync();









    }
}
