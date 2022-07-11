using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Lib.Logger.Serilog
{
    public class SerilogFileLoggerConfiguration
    {
        public int EventId { get; set; }

        public Dictionary<LogLevel, ConsoleColor> LogLevels { get; set; } = new()
        {
            [LogLevel.Information] = ConsoleColor.Green,
            [LogLevel.Error] = ConsoleColor.Red
        };
    }
}
