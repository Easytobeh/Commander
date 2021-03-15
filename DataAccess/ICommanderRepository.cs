﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Models;
namespace Commander.DataAccess
{
    public interface ICommanderRepository
    {
        IEnumerable<Command> GetAppsCommands();
        Command GetCommandById(int id);

    }
}