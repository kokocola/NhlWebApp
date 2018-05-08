using NhlLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NhlLib.Classes
{
    public class Player : IPlayer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Nationality { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public string Team { get; set; }
    }
}
