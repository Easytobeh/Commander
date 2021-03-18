using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Models;
using Commander.DataAccess;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : Controller
    {
        private readonly ICommanderRepository _repository;
        public CommandsController(ICommanderRepository repository)
        {
            _repository = repository;
        }
        ///private readonly MockCommanderRepo _repository = new MockCommanderRepo();
            [HttpGet] public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
       
        }

       [HttpGet("{id}")] public ActionResult<Command> GetCommands(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}
