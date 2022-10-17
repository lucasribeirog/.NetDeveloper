using EcommerceAPI.Application.Dtos;
using EcommerceAPI.Application.Interfaces;
using EcommerceAPI.Application.Mappers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EcommerceWebApi.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IApplicationServiceUser _applicationServiceUser;
        private readonly IMapperUser _mapperUser;

        public UserController(IApplicationServiceUser applicationServiceUser, IMapperUser mapperUser)
        {
            this._applicationServiceUser = applicationServiceUser;
            this._mapperUser = mapperUser;
        }

        #region Get

        // GET api/values/5
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceUser.GetAll());
        }

        // GET api/values/10
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceUser.GetById(id));
        }

        #endregion Get

        #region Post

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] UserDtoRegister userDtoRegister)
        {
            try
            {
                if (userDtoRegister is null)
                    return NotFound();

                _applicationServiceUser.Add(_mapperUser.MapperUserDtoRegisterToUserDTO(userDtoRegister));
                return Ok("User registered with success!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Post

        #region Put

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto is null)
                    return NotFound();

                _applicationServiceUser.Update(userDto);
                return Ok("User Updated with success!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Put

        [HttpPatch]
        public ActionResult Patch([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto is null)
                    return NotFound();

                _applicationServiceUser.Update(userDto);
                return Ok("User Updated with success!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Delete

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] UserDtoDelete userDtoDelete)
        {
            try
            {
                if (userDtoDelete is null)
                    return NotFound();

                _applicationServiceUser.Remove(_mapperUser.MapperUserDtoDeleteToUserDTO(userDtoDelete));
                return Ok("User Removed with success!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion Delete
    }
}