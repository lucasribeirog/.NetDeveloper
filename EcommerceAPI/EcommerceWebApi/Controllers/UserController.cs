using EcommerceAPI.Application.Dtos;
using EcommerceAPI.Application.Interfaces;
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

        public UserController(IApplicationServiceUser applicationServiceUser)
        {
            this._applicationServiceUser = applicationServiceUser;
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
        public ActionResult Post([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto == null)
                    return NotFound();

                _applicationServiceUser.Add(userDto);
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
        public ActionResult Put([FromBody] UserDto userDtp)
        {
            try
            {
                if (userDtp == null)
                    return NotFound();

                _applicationServiceUser.Update(userDtp);
                return Ok("User Updated with success!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion Put

        #region Delete

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] UserDto userDto)
        {
            try
            {
                if (userDto == null)
                    return NotFound();

                _applicationServiceUser.Remove(userDto);
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