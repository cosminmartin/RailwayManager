namespace RailwayManagerApi.Controllers
{
    [ApiController]
    [Route("trains")]
    public class TrainController : ControllerBase
    {
        private readonly ITrainQueries queries;
        private readonly ITrainCommands commands;
        public TrainController(ITrainQueries queries, ITrainCommands commands)
        {
            this.queries = queries;
            this.commands = commands;
        }

        [HttpGet("{trainId:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid trainId)
        {
            return Ok(await queries.GetTrainAsync(new GetTrainByIdQuery(trainId)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrain([FromBody] CreateTrainDto train)
        {
            return Ok(await commands.CreateTrainAsync(new CreateTrainCommand(train.Name, train.DepartureStation, train.ArrivalStation, train.DepartureDate, train.ArrivalDate, train.Duration, train.Status)));
        }
    }
}
