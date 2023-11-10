using Microsoft.EntityFrameworkCore;
using DaryaAlexeevaKT4120.Database;
using DaryaAlexeevaKT4120.Filters.GroupFilters;
using DaryaAlexeevaKT4120.Models;

namespace DaryaAlexeevaKT4120.Interfaces.GroupsInterfaces
{
    public interface IGroupService
    {
        public Task<Group[]> GetGroupsBySpecAsync(GroupSpecFilter filter, CancellationToken cancellationToken);
    }
    public class GroupService : IGroupService
    {

        private readonly GroupDbContext _dbContext;

        public GroupService(GroupDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Group[]> GetGroupsBySpecAsync(GroupSpecFilter filter, CancellationToken cancellationToken = default)
        {
            var groups = _dbContext.Set<Group>().Where(d => d.Specializations.SpecName == filter.SpecName && d.YearGroup == filter.Year && d.ExistGroup == filter.ExistGroup).ToArrayAsync(cancellationToken);
            return groups;
        }
    }
}
