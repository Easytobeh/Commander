using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.DataAccess
{
    public class SqlCommanderRepo : ICommanderRepository
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentException(nameof(cmd));
            }
            _context.Commands.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(predicate => predicate.Id == id);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0 );
        }

        public void UpdateCommand(Command cmd)
        {
            
        }
    }
}
