using Lib.Classes;
using Lib.Helpers;
using NhlLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lib.Interfaces.Services;
using NhlLib;

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
        public IList<Team> GetAllTeams()
        {
            var apiTeams = ApiUtility.GetDeserializeObject<StatTeamApi>($"{baseApiUrl}{endpoints[ApiEndpoints.Teams]}");
            return apiTeams.Teams ?? null;
        }

        public ITeam GetTeamById(int id)
        {
            var team = ApiUtility.GetDeserializeObject<StatTeamApi>($"{baseApiUrl}{endpoints[ApiEndpoints.Teams]}/{id}").Teams.FirstOrDefault();
            return team ?? null;
        }

        public StatsApiPlayer GetPlayerById(int id)
        {
            var player = ApiUtility.GetDeserializeObject<StatsApiPlayers>($"{baseApiUrl}{endpoints[ApiEndpoints.People]}/{id}").People.FirstOrDefault();
            return player;
        }

        public PlayerStats GetPlayerSeasonStats(int id, int seasonStartYear, int seasonEndYear, TypeOfGame game = TypeOfGame.Regular)
        {
            var url = $"{baseApiUrl}{endpoints[ApiEndpoints.People]}/{id}/stats?season={seasonStartYear}{seasonEndYear}&stats=statsSingleSeason";
            var stat = ApiUtility.GetDeserializeObject<StatsPlayerPerSeason>(url);
            var playerStats = stat.Stats.FirstOrDefault()?.Splits.FirstOrDefault()?.Stat;
            if (playerStats != null) {
                playerStats.SeasonStart = seasonStartYear;
                playerStats.SeasonEnd = seasonEndYear;
            }
            return playerStats;
        }

        public IList<StatApiRosterPlayer> GetTeamRoster(int id)
        {
            var apiTeamRoster = ApiUtility.GetDeserializeObject<StatApiTeamRoster>($"{baseApiUrl}{endpoints[ApiEndpoints.Teams]}/{id}/roster");
            return apiTeamRoster?.Roster?.ToList();
        }
    }
}
