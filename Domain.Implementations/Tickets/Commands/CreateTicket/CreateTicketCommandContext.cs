namespace Domain.Implementations.Tickets.Commands.CreateTicket
{
    public class CreateTicketCommandContext : ICreateTicketCommandContext
    {
        private readonly ITicketWriteRepository ticketWriteRepository;
        private readonly IValidator<CreateTicketCommand> validator;
        public CreateTicketCommandContext(ITicketWriteRepository ticketWriteRepository, IValidator<CreateTicketCommand> validator)
        {
            this.ticketWriteRepository = ticketWriteRepository;
            this.validator = validator;
        }

        public async Task<TicketDto> Execute(CreateTicketCommand command)
        {
            var validationResult = await validator.ValidateAsync(command);

            if (!validationResult.IsValid)
            {
                var failures = validationResult.Errors.Where(x => x != null).ToList();

                throw new InvalidRequestException(new ValidationException("Validation exception", failures));
            }

            var result = await ticketWriteRepository.CreateTicketAsync(new CreateTicketContract(command.TrainId, command.UserId, command.RailroadCar, command.TrainSeat, command.Price));

            return result.ToModel().ToDto();
        }
    }
}
