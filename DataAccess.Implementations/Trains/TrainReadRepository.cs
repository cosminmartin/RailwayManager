namespace DataAccess.Implementations.Trains
{
    public class TrainReadRepository : RepositoryBase, ITrainReadRepository
    {
        public TrainReadRepository(DbContext context) : base(context) { }

        public async Task<Train> GetTrainAsync(GetTrainByIdContract contract)
        {
            var connection = context.CreateConnection();
            await connection.OpenAsync();

            const string query = $@"SELECT * FROM Trains WHERE Trains.Id = @TrainId";
            var parameters = new { TrainId = contract.TrainId };

            return await connection.QueryFirstOrDefaultAsync<Train>(query, parameters);
        }
    }
}
