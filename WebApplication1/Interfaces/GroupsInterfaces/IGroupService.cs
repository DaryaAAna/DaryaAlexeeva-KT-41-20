using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Filters.GroupFilters;
using WebApplication1.Models;

namespace WebApplication1.Interfaces.GroupsInterfaces
{
    public interface IGroupService
    {
        public Task<Group[]> GetGroupsBySpecAsync(GroupSpecFilter filter, CancellationToken cancellationToken);
    }
    public class GroupServices : IGroupService
    {

        private readonly GroupDbContext _dbContext;

        public GroupServices(GroupDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
