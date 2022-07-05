namespace StatsApi
{
    using Lib.Classes;
    using Newtonsoft.Json;
    using System;

    public partial class StatsPlayerPerSeason
    {
        [JsonProperty("stats")]
        public StatElement[] Stats { get; set; }
    }

    public partial class StatElement
    {
        [JsonProperty("type")]
        public TypeClass Type { get; set; }

        [JsonProperty("splits")]
        public Split[] Splits { get; set; }
    }

    public partial class Split
    {
        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("stat")]
        public PlayerStats Stat { get; set; }
    }

    public partial class TypeClass
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("gameType")]
        public GameType GameType { get; set; }
    }

    public partial class GameType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("postseason")]
        public bool Postseason { get; set; }
    }
}
