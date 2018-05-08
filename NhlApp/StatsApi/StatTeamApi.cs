using Lib.JsonConverters;
using Newtonsoft.Json;
using NhlLib.Interfaces;
using System;
using System.Collections.Generic;

namespace StatsApi
{
    public class StatTeamApi
    {
        [JsonConverter(typeof(ConcreteListTypeConverter<ITeam,Team>))]
        public IList<ITeam> Teams { get; set; }

    }

    public class Team : ITeam
    {
        [JsonProperty("id")]
        public int Id { get; set; }

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
    }

    public class Division
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Conference
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
