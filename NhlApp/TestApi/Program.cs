using Lib.Helpers;
using Newtonsoft.Json;
using NhlLib.Interfaces;
using StatsApi;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace TestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var statsApi = new StatsApiAdapter();

            foreach (var team in statsApi.GetTeamRoster(1))
            {
                Console.WriteLine(team.PlayerNumber);
            }
            
            Console.ReadLine();
        }
    }
}
