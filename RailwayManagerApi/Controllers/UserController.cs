namespace RailwayManagerApi.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserQueries queries;
        private readonly IUserCommands commands;
        public UserController(IUserQueries queries, IUserCommands commands)
        {
            this.queries = queries;
            this.commands = commands;
        }

		[Authorize]
		[HttpGet("{userId:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid userId)
        {
            return Ok(await queries.GetUserAsync(new GetUserByIdQuery(userId)));
        }

        [HttpGet("{userEmail}")]
        public async Task<IActionResult> GetByEmail([FromRoute] string userEmail)
        {
            return Ok(await queries.GetUserAsync(new GetUserByEmailQuery(userEmail)));
        }

		[AllowAnonymous]
		[HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto user)
        {
            return Ok(await commands.CreateUserAsync(new CreateUserCommand(user.Email, user.FirstName, user.LastName, user.Password, user.PhoneNumber)));
        }

		[AllowAnonymous]
		[HttpPost("login")]
		[SwaggerOperation(Summary = "Login with user credential to get an authentification token")]
		public async Task<IActionResult> Login([FromBody] LoginUserCommand request)
		{
			return Ok(await commands.LoginUserAsync(request));
		}
	}
}
