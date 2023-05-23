namespace Domain.Implementations.Tickets.Queries.GetById
{
    public class GetTicketByIdQueryContext : IGetTicketByIdQueryContext
    {
        private readonly ITicketReadRepository ticketReadRepository;
        private readonly IValidator<GetTicketByIdQuery> validator;

        public GetTicketByIdQueryContext(ITicketReadRepository ticketReadRepository, IValidator<GetTicketByIdQuery> validator)
        {
            this.ticketReadRepository = ticketReadRepository;
            this.validator = validator;
        }

        public async Task<TicketDto> Execute(GetTicketByIdQuery query)
        {
            var validationResult = await validator.ValidateAsync(query);

            if (!validationResult.IsValid) 
            { 
                var failures = validationResult.Errors.Where(x=> x != null).ToList();

                throw new InvalidRequestException(new ValidationException("Validation exception", failures));
            }

            var result = await ticketReadRepository.GetTicketAsync(new GetTicketByIdContract(query.TicketId));

            if(result == null)
            {
                throw new NotFoundException("The ticket id is not inside the database.");
            }

            return result.ToModel().ToDto();
        }
    }
}
