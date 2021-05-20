using System;
using Cron.Interface;
using Serilog;

namespace Cron.CLI.Logging
{
    public class CronLogger: ICronLogger
    {
        private readonly ILogger _logger;
        public CronLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Info(string message)
        {
            _logger.Information(message);
        }

        public void Warning(string message)
        {
            _logger.Warning(message);
        }

        public void Trace(string message)
        {
            _logger.Verbose(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }
        
        public void Error(Exception e)
        {
            _logger.Error(e, "Error occurred");
        }

        public void Error(Exception e, string error)
        {
            _logger.Error(e, error);
        }
    }
}