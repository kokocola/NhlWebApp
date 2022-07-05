using Newtonsoft.Json;
using NhlLib.Classes;
using NhlLib.Interfaces;
using System;
using System.Collections.Generic;

namespace NhlLib
{
    public class Team : ITeam
    {
        public int Id { get; set; }

        [JsonProperty("id")]
        public int NhlTeamId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        [JsonProperty("franchiseId")]
        public string FranchiseId { get; set; }

        public List<Player> Players { get; set; }
    }
}
