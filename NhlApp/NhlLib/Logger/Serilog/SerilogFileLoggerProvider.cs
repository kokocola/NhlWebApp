﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Logger.Serilog
{
    [ProviderAlias("SerilogFile")]
    public sealed class SerilogFileLoggerProvider : ILoggerProvider
    {
        private readonly IDisposable _onChangeToken;
        private SerilogFileLoggerConfiguration _currentConfig;
        private readonly ConcurrentDictionary<string, SerilogFileLogger> _loggers =
            new(StringComparer.OrdinalIgnoreCase);

        public SerilogFileLoggerProvider(
            IOptionsMonitor<SerilogFileLoggerConfiguration> config)
        {
            _currentConfig = config.CurrentValue;
            _onChangeToken = config.OnChange(updatedConfig => _currentConfig = updatedConfig);
        }

        public ILogger CreateLogger(string categoryName) =>
            _loggers.GetOrAdd(categoryName, name => new SerilogFileLogger(name, GetCurrentConfig));

        private SerilogFileLoggerConfiguration GetCurrentConfig() => _currentConfig;

        public void Dispose()
        {
            _loggers.Clear();
            _onChangeToken.Dispose();
        }
    }
}
