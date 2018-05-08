using Lib.JsonConverters;
using Newtonsoft.Json;
using NhlLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatsApi
{
    public class StatPlayerApi
    {
        [JsonConverter(typeof(ConcreteListTypeConverter<RosterPlayer,RosterPlayer>))]
        public IList<RosterPlayer> Roster { get; set; }
    }

    public class RosterPlayer
    {
        [JsonProperty("person")]
        [JsonConverter(typeof(ConcreteTypeConverter<Player>))]
        public IPlayer Player { get; set; }

        [JsonProperty("jerseyNumber")]
        public string PlayerNumber { get; set; }
    }

    public class Player : IPlayer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonConverter(typeof(ConcreteTypeConverter<Team>))]
        public ITeam CurrentTeam { get; set; }

        public string Team { get; set; }
    }
}
