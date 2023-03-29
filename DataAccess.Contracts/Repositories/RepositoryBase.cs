namespace DataAccess.Contracts.Repositories
{
    public class RepositoryBase
    {
        protected readonly DbContext context;
        public RepositoryBase(DbContext context)
        {
            this.context = context;
        }
    }
}
