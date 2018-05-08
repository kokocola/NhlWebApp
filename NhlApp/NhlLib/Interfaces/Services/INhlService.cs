using NhlLib;
using NhlLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Interfaces.Services
{
    public interface INhlService
    {
        IList<ITeam> GetAllTeams();

        ITeam GetTeamById(int id);
    }
}
