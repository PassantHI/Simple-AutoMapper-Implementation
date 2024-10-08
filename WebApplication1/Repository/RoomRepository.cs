using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApplication1.DTOs;
using WebApplication1.Models;
using WebApplication1.Mapping;
using System.Linq;

namespace WebApplication1.Repository
{
    public class RoomRepository : IRoomRepository
    {
        protected AppDBContext context;
        private readonly IMapper mapper;

        public RoomRepository(AppDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<RoomDTO> GetByIdAsync(int id)
        {
            return await context.Rooms.Where(a=>a.RoomID==id)
                .ProjectTo<RoomDTO>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
           
        }

        public async Task<IEnumerable<RoomDTO>> GetListAsync(Expression<Func<Room, bool>>? expression = null)
        {
            IQueryable<Room> Query = context.Rooms;

            if (expression != null) Query = Query.Where(expression);

            return await  Query.ProjectTo<RoomDTO>(mapper.ConfigurationProvider).ToListAsync();
            
        }

        public async Task<bool> SaveAllAsync()
        {

            return await context.SaveChangesAsync() > 0;
        }

    }
}
