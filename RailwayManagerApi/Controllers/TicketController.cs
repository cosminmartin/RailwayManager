namespace RailwayManagerApi.Controllers
{
    [ApiController]
    [Route("tickets")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketQueries queries;

        public TicketController(ITicketQueries queries)
        {
            this.queries = queries;
        }

        [HttpGet("{ticketId:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid ticketId)
        {
            return Ok(await queries.GetTicketAsync(new GetTicketByIdQuery(ticketId)));
        }
    }
}
