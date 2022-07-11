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
using Microsoft.Extensions.Logging;
using Lib.Logger.Serilog;

namespace TestApi
{
    class Program
    {
        static void Main(string[] args)
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddSerilogFileLogger(configuration =>
                {
                    // Replace warning value from appsettings.json of "Cyan"
                    configuration.LogLevels[LogLevel.Warning] = ConsoleColor.DarkCyan;
                    // Replace warning value from appsettings.json of "Red"
                    configuration.LogLevels[LogLevel.Error] = ConsoleColor.DarkRed;
                });
            });

            Microsoft.Extensions.Logging.ILogger logger = loggerFactory.CreateLogger<Program>();

            logger.LogInformation($"Test");

            logger.LogError($"Test2");

            Console.ReadLine();
        }
    }
}
