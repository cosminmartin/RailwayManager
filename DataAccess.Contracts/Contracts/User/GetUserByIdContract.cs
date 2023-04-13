namespace DataAccess.Contracts.Contracts.User
{
    public class GetUserByIdContract
    {
        public Guid UserId { get; }
        public GetUserByIdContract(Guid userId)
        {
            UserId = userId;
        }
    }
}
