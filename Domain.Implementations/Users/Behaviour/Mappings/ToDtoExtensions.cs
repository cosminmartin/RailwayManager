﻿namespace Domain.Implementations.Users.Behaviour.Mappings
{
    internal static class ToDtoExtensions
    {
        public static UserDto ToDto(this UserModel model) => new()
        {
            Id = model.Id,
            FirstName = model.FirstName,
            LastName = model.LastName,
            PhoneNumber = model.PhoneNumber,
            Email = model.Email
        };

        public static IEnumerable<UserDto> ToDto(this IReadOnlyCollection<UserModel> models) =>
            models.Select(m => m.ToDto());
    }
}