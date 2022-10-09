using EcommerceAPI.Application.Dtos;
using EcommerceAPI.Application.Interfaces;
using EcommerceAPI.Application.Mappers.Interfaces;
using EcommerceAPI.Core.Interfaces.Services;
using EcommerceAPI.Domain.Entities;
using System.Collections.Generic;

namespace EcommerceAPI.Application
{
    public class ApplicationServiceUser : IApplicationServiceUser
    {
        private readonly IServiceUser _serviceUser;
        private readonly IMapperUser _mapperUser;

        public ApplicationServiceUser(IServiceUser serviceUser, IMapperUser mapperUser)
        {
            this._serviceUser = serviceUser;
            this._mapperUser = mapperUser;
        }

        public void Add(UserDto userDto)
        {
            User user = _mapperUser.MapperDtoToEntity(userDto);
            _serviceUser.Add(user);
        }

        public IEnumerable<UserDto> GetAll()
        {
            IEnumerable<User> users = _serviceUser.GetAll();
            IEnumerable<UserDto> userDtos = _mapperUser.MapperListUsersDto(users);
            return userDtos;
        }

        public UserDto GetById(int id)
        {
            User user = _serviceUser.GetById(id);
            UserDto userDto = _mapperUser.MapperEntityToDto(user);
            return userDto;
        }

        public void Remove(UserDto userDto)
        {
            User user = _mapperUser.MapperDtoToEntity(userDto);
            _serviceUser.Remove(user);
        }

        public void Update(UserDto userDto)
        {
            User user = _mapperUser.MapperDtoToEntity(userDto);
            _serviceUser.Update(user);
        }
    }
}