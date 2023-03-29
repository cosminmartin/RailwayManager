namespace DataAccess.Contracts.Contracts
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
