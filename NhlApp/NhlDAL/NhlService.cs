using Lib.Interfaces.Services;
using NhlLib;
using NhlLib.Interfaces;
using StatsApi;
using System.Collections.Generic;

namespace NhlDAL
{
    public class NhlService : INhlService
    {
        public INhlService serviceAdapter;

        public NhlService()
        {
            serviceAdapter = new StatsApiAdapter();
        }

        public NhlService(INhlService adapter)
        {
            this.serviceAdapter = adapter;
        }

        public IList<ITeam> GetAllTeams()
        {
            return serviceAdapter.GetAllTeams();
        }

        public ITeam GetTeamById(int id)
        {
            return serviceAdapter.GetTeamById(id);
        }
    }
}
