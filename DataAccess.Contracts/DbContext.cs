namespace DataAccess.Contracts
{
    public class DbContext
    {
        public readonly string ConnectionString;

        public DbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public SqlConnection CreateConnection() => new(ConnectionString);
    }
}
