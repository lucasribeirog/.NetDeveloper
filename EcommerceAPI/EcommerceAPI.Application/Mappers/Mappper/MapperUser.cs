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
                Address = userDto.Address,
                Email = userDto.Email
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
                Address = user.Address,
                Email = user.Email
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
                Address = u.Address,
                Email = u.Email
            });

            return userDtos;
        }

        public UserDto MapperUserDtoRegisterToUserDTO(UserDtoRegister userDtoRegister)
        {
            UserDto userDto = new UserDto
            {
                Id = 0,
                Name = userDtoRegister.Name,
                Login = userDtoRegister.Login,
                Password = userDtoRegister.Password,
                Status = userDtoRegister.Status,
                Address = userDtoRegister.Address,
                Email = userDtoRegister.Email
            };
            return userDto;
        }

        public UserDto MapperUserDtoDeleteToUserDTO(UserDtoDelete userDtoDelete)
        {
            UserDto userDto = new UserDto
            {
                Id = userDtoDelete.Id,
                Name = string.Empty,
                Login = string.Empty,
                Password = string.Empty,
                Status = 0,
                Address = string.Empty,
                Email = string.Empty
            };
            return userDto;
        }
    }
}