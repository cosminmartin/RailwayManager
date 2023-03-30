namespace Domain.Implementations.Users.Behaviour.Mappings
{
    internal static class ToModelExtensions
    {
        public static UserModel ToModel(this User entity) => new()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            PhoneNumber = entity.PhoneNumber,
            Email = entity.Email,
            PasswordHash = entity.PasswordHash,
            PasswordSalt = entity.PasswordSalt
        };

        public static IEnumerable<UserModel> ToModel(this IReadOnlyCollection<User> entities) =>
            entities.Select(e => e.ToModel());
    }
}
