using Lib.Classes;
using Lib.Helpers;
using NhlLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lib.Interfaces.Services;

namespace StatsApi
{
    public class StatsApiAdapter : INhlService, IAdapter
    {
        static readonly string baseApiUrl = "https://statsapi.web.nhl.com/api/v1/";
        public static Dictionary<ApiEndpoints, string> endpoints = new Dictionary<ApiEndpoints, string>
        {
            { ApiEndpoints.Teams, "teams" },
            { ApiEndpoints.People, "people" },
            { ApiEndpoints.Standings, "standings" },
            { ApiEndpoints.Schedule, "schedule" },
            { ApiEndpoints.Game, "game" }
        };
        public IList<ITeam> GetAllTeams()
        {
            var apiTeams = ApiUtility.GetDeserializeObject<StatTeamApi>($"{baseApiUrl}{endpoints[ApiEndpoints.Teams]}");
            return apiTeams.Teams ?? null;
        }

        public ITeam GetTeamById(int id)
        {
            var team = ApiUtility.GetDeserializeObject<StatTeamApi>($"{baseApiUrl}{endpoints[ApiEndpoints.Teams]}/{id}").Teams.FirstOrDefault();
            return team ?? null;
        }

        public IList<RosterPlayer> GetTeamRoster(int id)
        {
            var apiTeamRoster = ApiUtility.GetDeserializeObject<StatPlayerApi>($"{baseApiUrl}{endpoints[ApiEndpoints.Teams]}/{id}/roster");
            return apiTeamRoster.Roster ?? null;
        }
    }
}
