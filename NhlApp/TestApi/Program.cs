using Lib.Helpers;
using NhlLib.Interfaces;
using StatsApi;
using System;
using Serilog;
using Serilog.Events;
using NhlLib.Classes;
using Mapster;
using System.Linq;
using NhlLib;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using NhlDAL;

namespace TestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            .Enrich.FromLogContext()
            .WriteTo.File("console_Log_nhl.txt", fileSizeLimitBytes: null).WriteTo.Console()
            .CreateLogger();

            TypeAdapterConfig<StatsApiPlayer, Player>.NewConfig()
                            .Map(dest => dest.JerseyNumber, src => src.PrimaryNumber)
                            .Map(dest => dest.Position, src => src.PrimaryPosition.Type)
                            .Map(dest => dest.NhlPlayerId, src => src.PlayerId)
                            .Map(dest => dest.Age, src => src.CurrentAge);



            var statsApi = new StatsApiAdapter();
            var context = new NhlContext();

            try
            {
                Console.WriteLine("Start!");
                //var player = context.Players.Where(item => item.NhlPlayerId == 8480222).FirstOrDefault();
                var teams = context.Teams.Include(m => m.Players).ToList(); //This gets all teams + players
                //Console.WriteLine(player);
                var nullPlayers = new List<Player>();
                for (int i = 2018; i < 2020; i++)
                {
                    teams.ForEach(item => {
                        Log.Information($"Currently grabbing player stats for team: {item.Name}. There are {item.Players.Count} players on this team.");

                        item.Players.ForEach(player =>
                        {
                            Log.Information("Adding stat for current Player Name: {playerName}.", $"{player.FirstName} {player.LastName}");

                            var playerStats = statsApi.GetPlayerSeasonStats(player.NhlPlayerId, i, i+1);
                            if (playerStats != null)
                            {
                                playerStats.PlayerId = player.Id;
                                context.PlayerStats.Add(playerStats);
                                context.SaveChanges();
                                Log.Information("Done adding user.");
                            }
                            else
                            {
                                nullPlayers.Add(player);
                                Log.Error($"Errorr! User {player.FirstName} {player.LastName} is null, skipping.");
                            }
                        });

                        Log.Information("Stopping for 5 seconds to not hit API too much.");
                        Thread.Sleep(5000);
                    });
                }


                Log.Error($"There are {nullPlayers.Count} errored players.");
                nullPlayers.ForEach(item =>
                {
                    Log.Error($"User: {item.FirstName} {item.LastName} has failed.");
                });


                //var teams = statsApi.GetAllTeams().Where(item => (item as Team).NhlTeamId != 1);


                /*
                foreach (var team in teams)
                {
                    foreach (var rosterPlayer in statsApi.GetTeamRoster(team.NhlTeamId))
                    {
                        var player = statsApi.GetPlayerById(rosterPlayer.Person.Id);
                        var playerDTO = player.Adapt<Player>();
                        var currentTeam = context.Teams.Where(team => team.NhlTeamId == player.CurrentTeam.Id).FirstOrDefault();
                        playerDTO.TeamId = currentTeam.Id;
                        context.Players.Add(playerDTO);
                        context.SaveChanges();

                        Log.Information("Current Player Name: {playerName} and number {playerNumber}. Player plays {position}.", playerDTO.FirstName, playerDTO.JerseyNumber, playerDTO.Position);
                    }
                }
                */
                /*
                foreach (var team in statsApi.GetAllTeams())
                {
                    Log.Information("Current Team: {name} and id {id}", team.Name, team.Id);
  
                    using (var context = new NhlContext())
                    {
                        context.Teams.Add(team as Team);
                        context.SaveChanges();
                    }
                }
                */
                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }

            Console.ReadLine();
        }
    }
}
