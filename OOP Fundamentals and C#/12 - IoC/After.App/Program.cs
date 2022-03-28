
using After.DIContainer;
using After.Logging.Targets;

var logger = LoggerFactory.GetLogger(LoggingType.Console);

logger.LogMessage("Program executed successfully", LoggerFactory.GetLogFormatter());
logger.LogMessage("An exception occurred", LoggerFactory.GetLogFormatter(true));
