using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;

namespace Service.Models
{
    public class RttLogger
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void WriteToLog(LogType logType, string message)
        {
            switch (logType)
            {
                case LogType.Debug:
                    logger.Debug(message);
                    break;
                case LogType.Error:
                    logger.Error(message);
                    break;
                case LogType.Fatal:
                    logger.Fatal(message);
                    break;
                case LogType.Info:
                    logger.Info(message);
                    break;
                case LogType.Log:
                    logger.Log(LogLevel.Info, message);
                    break;
                case LogType.Trace:
                    logger.Trace(message);
                    break;
                case LogType.Warn:
                    logger.Warn(message);
                    break;
            }
        }
    }
}