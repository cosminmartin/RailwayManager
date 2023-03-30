namespace Domain.Contracts.Users.Queries.GetById
{
    public class GetUserByIdQuery
    {
        public Guid UserId { get; set; }

        public GetUserByIdQuery(Guid userId) 
        {
            UserId = userId;    
        }
    }
}
