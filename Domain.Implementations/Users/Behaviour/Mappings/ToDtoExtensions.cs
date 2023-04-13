using Domain.Contracts.Dtos.User;

namespace Domain.Implementations.Users.Behaviour.Mappings
{
    internal static class ToDtoExtensions
    {
        public static UserDto ToDto(this UserModel model) => new()
        {
            Id = model.Id,
            Email = model.Email,
            FirstName = model.FirstName,
            LastName = model.LastName,
            PhoneNumber = model.PhoneNumber
        };

        public static IEnumerable<UserDto> ToDto(this IReadOnlyCollection<UserModel> models) =>
            models.Select(m => m.ToDto());
    }
}
