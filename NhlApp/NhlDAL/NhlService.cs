using Lib.Classes;
using Lib.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using NhlLib;
using NhlLib.Classes;
using NhlLib.Interfaces;
using StatsApi;
using System.Collections.Generic;
using System.Linq;

namespace NhlDAL
{
    public class NhlService : INhlService
    {
        private readonly NhlContext _context;

        public NhlService(NhlContext _ctx)
        {
            _context = _ctx;
        }

        public IList<Team> GetAllTeams()
        {
            return _context.Teams.ToList();
        }

        public DbSet<Player> PlayerContext() => _context.Players;

        public DbSet<Team> TeamContext() => _context.Teams;

        public DbSet<PlayerStats> PlayerStatsContext() => _context.PlayerStats;

        public ITeam GetTeamById(int id)
        {
            return GetAllTeams().Where(item => item.NhlTeamId == id).FirstOrDefault();
        }
    }
}
