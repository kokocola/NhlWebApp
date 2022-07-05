using System;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NhlLib.Classes;

namespace StatsApi
{
    public partial class StatApiTeamRoster
    {
        [JsonProperty("roster")]
        public StatApiRosterPlayer[] Roster { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public partial class StatApiRosterPlayer
    {
        [JsonProperty("person")]
        public StatApiRosterPerson Person { get; set; }

        [JsonProperty("jerseyNumber")]
        public int JerseyNumber { get; set; }

        //[JsonProperty("position")]
       // public StatApiRosterPosition Position { get; set; }
    }

    public partial class StatApiRosterPerson
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public partial class StatApiRosterPosition
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PositionType Type { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
    }
}
