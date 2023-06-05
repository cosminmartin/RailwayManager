namespace Domain.Bootstrap
{
    public static class DIBootstrap
    {
        public static void RegisterDomainDI(this IServiceCollection services)
        {
            services.RegisterCommandContexts();
            services.RegisterValidators();
            services.RegisterQueriesContexts();
            services.AddTransient<IUserCommands, UserCommands>();
            services.AddTransient<IUserQueries, UserQueries>();
            services.AddTransient<ITrainCommands, TrainCommands>();
            services.AddTransient<ITrainQueries, TrainQueries>();
            services.AddTransient<ITicketQueries, TicketQueries>();
            services.AddTransient<ITicketCommands, TicketCommands>();
            services.RegisterPasswordManagerDI();
        }
        public static void RegisterCommandContexts(this IServiceCollection services)
        {
            services.AddTransient<ICreateUserCommandContext, CreateUserCommandContext>();
            services.AddTransient<ICreateTrainCommandContext, CreateTrainCommandContext>();
            services.AddTransient<IEditTrainCommandContext, EditTrainCommandContext>();
            services.AddTransient<IDeleteTrainCommandContext, DeleteTrainCommandContext>();
            services.AddTransient<ICreateTicketCommandContext, CreateTicketCommandContext>();
        }
        public static void RegisterQueriesContexts(this IServiceCollection services)
        {
            services.AddTransient<IGetUserByIdQueryContext, GetUserByIdQueryContext>();
            services.AddTransient<IGetTrainByIdQueryContext, GetTrainByIdQueryContext>();
            services.AddTransient<IGetAllTrainsQueryContext, GetAllTrainsQueryContext>();
            services.AddTransient<IGetTicketByIdQueryContext, GetTicketByIdQueryContext>();
        }

        public static void RegisterValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreateUserCommand>, CreateUserCommandValidator>();
            services.AddScoped<IValidator<GetUserByIdQuery>, GetUserByIdQueryValidator>();
            services.AddScoped<IValidator<CreateTrainCommand>, CreateTrainCommandValidator>();
            services.AddScoped<IValidator<EditTrainCommand>, EditTrainCommandValidator>();
            services.AddScoped<IValidator<DeleteTrainCommand>, DeleteTrainCommandValidator>();
            services.AddScoped<IValidator<GetTrainByIdQuery>, GetTrainByIdQueryValidator>();
            services.AddScoped<IValidator<GetAllTrainsQuery>, GetAllTrainsQueryValidator>();
            services.AddScoped<IValidator<GetTicketByIdQuery>, GetTicketByIdQueryValidator>();
            services.AddScoped<IValidator<CreateTicketCommand>, CreateTicketCommandValidator>();
        }
    }
}
