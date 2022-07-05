using Newtonsoft.Json;
using NhlLib.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Classes
{
    public class PlayerStats
    {
        public Guid PlayerStatsId { get; set; }

        [JsonProperty("timeOnIce")]
        public string TimeOnIce { get; set; }

        [JsonProperty("assists")]
        public int Assists { get; set; }

        [JsonProperty("goals")]
        public int Goals { get; set; }

        [JsonProperty("pim")]
        public int Pim { get; set; }

        [JsonProperty("shots")]
        public int Shots { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("powerPlayGoals")]
        public int PowerPlayGoals { get; set; }

        [JsonProperty("powerPlayPoints")]
        public int PowerPlayPoints { get; set; }

        [JsonProperty("powerPlayTimeOnIce")]
        public string PowerPlayTimeOnIce { get; set; }

        [JsonProperty("evenTimeOnIce")]
        public string EvenTimeOnIce { get; set; }

        [JsonProperty("penaltyMinutes")]
        public int PenaltyMinutes { get; set; }

        [JsonProperty("faceOffPct")]
        public double FaceOffPct { get; set; }

        [JsonProperty("shotPct")]
        public double ShotPct { get; set; }

        [JsonProperty("gameWinningGoals")]
        public int GameWinningGoals { get; set; }

        [JsonProperty("overTimeGoals")]
        public int OverTimeGoals { get; set; }

        [JsonProperty("shortHandedGoals")]
        public int ShortHandedGoals { get; set; }

        [JsonProperty("shortHandedPoints")]
        public int ShortHandedPoints { get; set; }

        [JsonProperty("shortHandedTimeOnIce")]
        public string ShortHandedTimeOnIce { get; set; }

        [JsonProperty("blocked")]
        public int Blocked { get; set; }

        [JsonProperty("plusMinus")]
        public int PlusMinus { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("shifts")]
        public int Shifts { get; set; }

        [JsonProperty("timeOnIcePerGame")]
        public string TimeOnIcePerGame { get; set; }

        [JsonProperty("evenTimeOnIcePerGame")]
        public string EvenTimeOnIcePerGame { get; set; }

        [JsonProperty("shortHandedTimeOnIcePerGame")]
        public string ShortHandedTimeOnIcePerGame { get; set; }

        [JsonProperty("powerPlayTimeOnIcePerGame")]
        public string PowerPlayTimeOnIcePerGame { get; set; }

        [JsonProperty("ot")]
        public long Ot { get; set; }

        [JsonProperty("shutouts")]
        public long Shutouts { get; set; }

        [JsonProperty("ties")]
        public long Ties { get; set; }

        [JsonProperty("wins")]
        public long Wins { get; set; }

        [JsonProperty("losses")]
        public long Losses { get; set; }

        [JsonProperty("saves")]
        public long Saves { get; set; }

        [JsonProperty("powerPlaySaves")]
        public long PowerPlaySaves { get; set; }

        [JsonProperty("shortHandedSaves")]
        public long ShortHandedSaves { get; set; }

        [JsonProperty("evenSaves")]
        public long EvenSaves { get; set; }

        [JsonProperty("shortHandedShots")]
        public long ShortHandedShots { get; set; }

        [JsonProperty("evenShots")]
        public long EvenShots { get; set; }

        [JsonProperty("powerPlayShots")]
        public long PowerPlayShots { get; set; }

        [JsonProperty("savePercentage")]
        public double SavePercentage { get; set; }

        [JsonProperty("goalAgainstAverage")]
        public double GoalAgainstAverage { get; set; }

        [JsonProperty("gamesStarted")]
        public long GamesStarted { get; set; }

        [JsonProperty("shotsAgainst")]
        public long ShotsAgainst { get; set; }

        [JsonProperty("goalsAgainst")]
        public long GoalsAgainst { get; set; }

        [JsonProperty("powerPlaySavePercentage")]
        public double PowerPlaySavePercentage { get; set; }

        [JsonProperty("shortHandedSavePercentage")]
        public double ShortHandedSavePercentage { get; set; }

        [JsonProperty("evenStrengthSavePercentage")]
        public double EvenStrengthSavePercentage { get; set; }

        public int SeasonStart { get; set; }

        public int SeasonEnd { get; set; }

        public TypeOfGame GameType { get; set; } = TypeOfGame.Regular;

        public int PlayerId { get; set; }

        public Player Player { get; set; }

    }

    public enum TypeOfGame {
        Regular,
        Playoffs
    }
}
