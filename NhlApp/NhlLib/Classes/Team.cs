using Newtonsoft.Json;
using NhlLib.Interfaces;
using System;

namespace NhlLib
{
    public class Team : ITeam
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }
    }
}
