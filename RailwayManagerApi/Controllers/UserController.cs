namespace RailwayManagerApi.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserQueries queries;
        private readonly IUserCommands commands;
        public UserController(IUserQueries queries, IUserCommands commands)
        {
            this.queries = queries;
            this.commands = commands;
        }

        [HttpGet("{userId:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid userId)
        {
            return Ok(await queries.GetUserAsync(new GetUserByIdQuery(userId)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto user)
        {
            return Ok(await commands.CreateUserAsync(new CreateUserCommand(user.Email, user.FirstName, user.LastName, user.Password, user.PhoneNumber)));
        }
    }
}
