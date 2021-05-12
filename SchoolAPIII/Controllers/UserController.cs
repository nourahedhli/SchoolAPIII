using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contracts;
using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using ActionFilters;
using Entities.RequestFeatures;
using Newtonsoft.Json;

namespace SchoolAPIII.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet(Name = "getAllUsers")]
        public IActionResult GetUsers()
        {
            var users = _repository.User.GetAllUsers(trackChanges: false);
            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return Ok(userDto);
        }

        [HttpGet("{id}", Name = "getUserById")]
        public IActionResult GetUser(Guid id)
        {
            var user = _repository.User.GetUser(id, trackChanges: false); if (user == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var userDto = _mapper.Map<UserDto>(user);
                return Ok(userDto);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, [FromBody] UserForUpdateDto user)
        {
            if (user == null)
            {
                _logger.LogError("UserForUpdateDto object sent from client is null.");
                return BadRequest("UserForUpdateDto object is null");
            }
            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UserForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }
            var userEntity = _repository.User.GetUser(id, trackChanges: true);
            if (userEntity == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _mapper.Map(user, userEntity);
            _repository.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            var user = _repository.User.GetUser(id, trackChanges: false);
            if (user == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }

            _repository.User.DeleteUser(user);
            _repository.Save();

            return NoContent();
        }




    }
}