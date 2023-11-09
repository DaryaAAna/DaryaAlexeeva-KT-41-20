using Microsoft.AspNetCore.Mvc;
using DaryaAlexeevaKT4120.Filters.GroupFilters;
using DaryaAlexeevaKT4120.Interfaces.GroupsInterfaces;

namespace DaryaAlexeevaKT4120.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupsController : Controller
    {
        private readonly ILogger<GroupsController> _logger;
        private readonly IGroupService _groupService;

        public GroupsController(ILogger<GroupsController> logger, IGroupService groupService)
        {
            _logger = logger;
            _groupService = groupService;
        }

        [HttpPost(Name = "GetGroupsBySpec")]

        public async Task<IActionResult> GetGroupsBySpecAsync(GroupSpecFilter filter, CancellationToken cancellationToken = default)
        {
            var groups = await _groupService.GetGroupsBySpecAsync(filter, cancellationToken);
            return Ok(groups);
        }
    }
}
