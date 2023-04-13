namespace Domain.Implementations.Users.Behaviour.Mappings
{
    internal static class ToModelExtensions
    {
        public static UserModel ToModel(this User entity) => new()
        {
            Id = entity.Id,
            Email = entity.Email,
            FirstName = entity.FirstName,
            LastName = entity.LastName,        
            PasswordHash = entity.PasswordHash,
            PasswordSalt = entity.PasswordSalt,
            PhoneNumber = entity.PhoneNumber
        };

        public static IEnumerable<UserModel> ToModel(this IReadOnlyCollection<User> entities) =>
            entities.Select(e => e.ToModel());
    }
}
