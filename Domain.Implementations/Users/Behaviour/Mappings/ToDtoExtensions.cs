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
		public static UserTokenDto ToDto(this UserModel model, string token) => new()
		{
			Email = model.Email,
			FirstName = model.FirstName,
			Id = model.Id,
			LastName = model.LastName,
			PhoneNumber = model.PhoneNumber,
			Token = token
		};
		public static IEnumerable<UserDto> ToDto(this IReadOnlyCollection<UserModel> models) =>
            models.Select(m => m.ToDto());
    }
}
