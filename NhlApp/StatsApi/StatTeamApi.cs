using Lib.JsonConverters;
using Newtonsoft.Json;
using NhlLib;
using NhlLib.Interfaces;
using System.Collections.Generic;

namespace StatsApi
{
    public class StatTeamApi
    {
        public IList<Team> Teams { get; set; }

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
