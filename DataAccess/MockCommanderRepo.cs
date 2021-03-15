﻿using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.DataAccess
{
    public class MockCommanderRepo : ICommanderRepository
    {
        public IEnumerable<Command> GetAppsCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "kettle and pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "get a knife", Platform = "knife and shopping board" },
                new Command { Id = 2, HowTo = "make a cup of tea", Line = "Place teabag in cup", Platform = "kettle and cup" }
        };
            return commands;
            //throw new NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water", Platform = "kettle and pan" };
           // throw new NotImplementedException();
        }
    }
}