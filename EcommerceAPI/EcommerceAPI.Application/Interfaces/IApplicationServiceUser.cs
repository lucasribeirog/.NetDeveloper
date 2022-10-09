using EcommerceAPI.Application.Dtos;
using System.Collections;
using System.Collections.Generic;

namespace EcommerceAPI.Application.Interfaces
{
    public interface IApplicationServiceUser
    {
        void Add(UserDto userDto);

        void Update(UserDto userDto);

        void Remove(UserDto userDto);

        IEnumerable<UserDto> GetAll();

        UserDto GetById(int id);
    }
}