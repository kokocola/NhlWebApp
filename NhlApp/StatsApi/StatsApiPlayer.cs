
using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NhlLib.Classes;

namespace StatsApi
{   public partial class StatsApiPlayers
    {
        [JsonProperty("people")]
        public StatsApiPlayer[] People { get; set; }
    }

    public partial class StatsApiPlayer
    {
        [JsonProperty("id")]
        public long PlayerId { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("primaryNumber")]
        public int PrimaryNumber { get; set; }

        [JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("currentAge")]
        public long CurrentAge { get; set; }

        [JsonProperty("birthCity")]
        public string BirthCity { get; set; }

        [JsonProperty("birthStateProvince")]
        public string BirthStateProvince { get; set; }

        [JsonProperty("birthCountry")]
        public string BirthCountry { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("weight")]
        public long Weight { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("alternateCaptain")]
        public bool AlternateCaptain { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("rookie")]
        public bool Rookie { get; set; }

        [JsonProperty("shootsCatches")]
        public string ShootsCatches { get; set; }

        [JsonProperty("rosterStatus")]
        public string RosterStatus { get; set; }

        [JsonProperty("currentTeam")]
        public CurrentTeam CurrentTeam { get; set; }

        [JsonProperty("primaryPosition")]
        public PrimaryPosition PrimaryPosition { get; set; }
    }

    public partial class CurrentTeam
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public partial class PrimaryPosition
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public PositionType Type { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
    }
}
