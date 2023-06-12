namespace RailwayManagerApi.Controllers
{
    [ApiController]
    [Route("api/tickets")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketQueries queries;
        private readonly ITicketCommands commands;

        public TicketController(ITicketQueries queries, ITicketCommands commands)
        {
            this.queries = queries;
            this.commands = commands;
        }

        [HttpGet("{ticketId:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid ticketId)
        {
            return Ok(await queries.GetTicketAsync(new GetTicketByIdQuery(ticketId)));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateTicket([FromBody] CreateTicketDto ticket)
        {
            return Ok(await commands.CreateTicketAsync(new CreateTicketCommand(ticket.TrainId, ticket.UserId, ticket.RailroadCar, ticket.TrainSeat, ticket.Price)));
        }
    }
}
