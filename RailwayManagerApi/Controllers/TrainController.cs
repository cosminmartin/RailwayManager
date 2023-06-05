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

        [HttpGet]
        [Route("{departureStation}/{arrivalStation}")]
        public async Task<IActionResult> GetAllTrainsAsync([FromRoute] string departureStation, string arrivalStation)
        {
            return Ok(await queries.GetAllTrainsAsync(new GetAllTrainsQuery(departureStation, arrivalStation)));   
        }

        [HttpPost]
        public async Task<IActionResult> CreateTrain([FromBody] CreateTrainDto train)
        {
            return Ok(await commands.CreateTrainAsync(new CreateTrainCommand(train.Name, train.DepartureStation, train.ArrivalStation, train.DepartureDate, train.ArrivalDate, train.Duration, train.Status)));
        }

        [HttpPut("{trainId:guid}")]
        public async Task<IActionResult> EditTrain([FromBody] EditTrainDto train)
        {
            return Ok(await commands.EditTrainAsync(new EditTrainCommand(train.Id, train.Name, train.DepartureStation, train.ArrivalStation, train.DepartureDate, train.ArrivalDate, train.Duration, train.Status)));
        }

        [HttpDelete("{trainId:guid}")]
        public async Task DeleteTrain([FromRoute] Guid trainId)
        {
            await commands.DeleteTrainAsync(new DeleteTrainCommand(trainId));
        }
    }
}
