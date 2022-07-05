using Lib.Classes;
using NhlLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhlLib.Classes
{
    public class Player : IPlayer
    {
        public int Id { get; set; }

        public int NhlPlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JerseyNumber { get; set; }
        public string Age { get; set; }
        public string Nationality { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }

        public DateTime BirthDate { get; set; }

        public PositionType Position { get; set; }

        public Team Team { get; set; }

        public int TeamId { get; set; }

        public List<PlayerStats> Stats { get; set; }
    }

    public enum PositionType { Defenseman, Forward, Goalie };
}
