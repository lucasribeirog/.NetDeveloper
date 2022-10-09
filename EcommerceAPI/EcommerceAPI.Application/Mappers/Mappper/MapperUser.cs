using EcommerceAPI.Application.Dtos;
using EcommerceAPI.Application.Mappers.Interfaces;
using EcommerceAPI.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceAPI.Application.Mappers.Mapper
{
    public class MapperUser : IMapperUser
    {
        private IEnumerable<UserDto> userDtos = new List<UserDto>();

        public User MapperDtoToEntity(UserDto userDto)
        {
            User user = new User()
            {
                Id = userDto.Id,
                Name = userDto.Name,
                Login = userDto.Login,
                Password = userDto.Password,
                Status = userDto.Status,
                Address = userDto.Address
            };

            return user;
        }

        public UserDto MapperEntityToDto(User user)
        {
            UserDto userDto = new UserDto()
            {
                Id = user.Id,
                Name = user.Name,
                Login = user.Login,
                Password = user.Password,
                Status = user.Status,
                Address = user.Address
            };

            return userDto;
        }

        public IEnumerable<UserDto> MapperListUsersDto(IEnumerable<User> users)
        {
            IEnumerable<UserDto> userDtos = users.Select(u => new UserDto
            {
                Id = u.Id,
                Name = u.Name,
                Login = u.Login,
                Password = u.Password,
                Status = u.Status,
                Address = u.Address
            });

            return userDtos;
        }
    }
}