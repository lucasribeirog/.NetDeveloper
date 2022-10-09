using EcommerceAPI.Application.Dtos;
using EcommerceAPI.Domain.Entities;
using System.Collections.Generic;

namespace EcommerceAPI.Application.Mappers.Interfaces
{
    public interface IMapperUser
    {
        User MapperDtoToEntity(UserDto userDto);

        IEnumerable<UserDto> MapperListUsersDto(IEnumerable<User> users);

        UserDto MapperEntityToDto(User user);
    }
}