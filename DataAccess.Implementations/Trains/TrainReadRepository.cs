using System.Text;

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

        public async Task<IEnumerable<Train>> GetAllTrainsAsync(GetAllTrainsContract contract)
        {
            var connection = context.CreateConnection();
            await connection.OpenAsync();

            const string query = @"     IF(@DepartureStation = 'all' AND @ArrivalStation = 'all')
                                          SELECT *
                                          FROM Trains t                                                                                        
                                          ORDER BY t.DepartureDate ASC

                                        ELSE IF(@DepartureStation = @DepartureStation AND @ArrivalStation = 'all')
                                          SELECT *
                                          FROM Trains t                                                      
                                          WHERE t.DepartureStation = @DepartureStation 
                                          ORDER BY t.DepartureDate ASC

                                        ELSE IF(@DepartureStation = 'all' AND @ArrivalStation = @ArrivalStation)
                                          SELECT *
                                          FROM Trains t                                                      
                                          WHERE t.ArrivalStation = @ArrivalStation
                                          ORDER BY t.ArrivalStation ASC

                                        ELSE
                                          SELECT *
                                          FROM Trains t                                                      
                                          WHERE t.DepartureStation = @DepartureStation AND t.ArrivalStation = @ArrivalStation
                                          ORDER BY t.DepartureDate ASC";

            var parameters = new { DepartureStation = contract.DepartureStation , ArrivalStation = contract.ArrivalStation };

            return await connection.QueryAsync<Train>(query, parameters);
        }
    }
}
