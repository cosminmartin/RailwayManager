namespace RailwayManagerApi.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserQueries queries;

        public UserController(IUserQueries queries)
        {
            this.queries = queries;
        }

        [HttpGet("{userId:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid userId)
        {
            return Ok(await queries.GetUserAsync(new GetUserByIdQuery(userId)));
        }
    }
}
