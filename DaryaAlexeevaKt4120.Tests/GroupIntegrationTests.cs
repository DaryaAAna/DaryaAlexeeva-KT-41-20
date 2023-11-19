using DaryaAlexeevaKT4120.Database;
using DaryaAlexeevaKT4120.Interfaces.GroupsInterfaces;
using DaryaAlexeevaKT4120.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaryaAlexeevaKt4120.Tests
{
    public class GroupIntegrationTests
    {
        public readonly DbContextOptions<GroupDbContext> _dbContextOptions;

        public GroupIntegrationTests()
        {
            _dbContextOptions = new DbContextOptionsBuilder<GroupDbContext>()
             .UseInMemoryDatabase(databaseName: "group_db")
             .Options;
        }

        [Fact]

        public async Task GetGroupsBySpecAsync_PrikladnayaInformatika_TwoObjects()
        {
            //Arrange
            var ctx = new GroupDbContext(_dbContextOptions);
            var groupService = new GroupService(ctx);
            var specializations = new List<Specialization>
            {
                new Specialization
                {
                    SpecId = 1,
                    SpecName = "Прикладная информатика"
                },
                new Specialization
                {
                    SpecId = 2,
                    SpecName = "Программная инженерия"
                }
            };
           await ctx.Set<Specialization>().AddRangeAsync(specializations);

            var groups = new List<Group>
            {
                new Group
                {
                    NumberGroup = "КТ-41-20",
                    YearGroup = 2020,
                    ExistGroup = true,
                    SpecId = 1,
                },
                new Group
                {
                    NumberGroup = "КТ-42-20",
                    YearGroup = 2020,
                    ExistGroup = true,
                    SpecId = 1,
                },
                new Group
                {
                    NumberGroup = "КТ-31-20",
                    YearGroup = 2020,
                    ExistGroup = true,
                    SpecId = 2,
                }
            };
            await ctx.Set<Group>().AddRangeAsync(groups);
            await ctx.SaveChangesAsync();

            //Act
            var filter = new DaryaAlexeevaKT4120.Filters.GroupFilters.GroupSpecFilter
            {
                SpecName = "Прикладная информатика",
                Year = 2020, 
                ExistGroup = true
            };
            var groupResult = await groupService.GetGroupsBySpecAsync(filter, CancellationToken.None);

            //Assert
            Assert.Equal(2, groupResult.Length);
        }
    }
}
