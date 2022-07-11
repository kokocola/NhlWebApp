using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using System;

namespace Lib.Logger.Serilog
{
    public static class SerilogFileLoggerExtensions
    {
        public static ILoggingBuilder AddSerilogFileLogger(
            this ILoggingBuilder builder)
        {
            builder.AddConfiguration();

            builder.Services.TryAddEnumerable(
                ServiceDescriptor.Singleton<ILoggerProvider, SerilogFileLoggerProvider>());

            LoggerProviderOptions.RegisterProviderOptions
                <SerilogFileLoggerConfiguration, SerilogFileLoggerProvider>(builder.Services);

            return builder;
        }

        public static ILoggingBuilder AddSerilogFileLogger(
            this ILoggingBuilder builder,
            Action<SerilogFileLoggerConfiguration> configure)
        {
            builder.AddSerilogFileLogger();
            builder.Services.Configure(configure);

            return builder;
        }
    }
}
