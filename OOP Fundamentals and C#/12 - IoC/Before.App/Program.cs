using Before.Logging;
using Before.Logging.Formatters;
using Before.Logging.Targets;

var logger = new LoggerManager();
var defaultFormatter = new DefaultLogFormatter();
var exceptionFormatter = new ExceptionLogFormatter();

logger.LogMessage("Program executed successfully", defaultFormatter);
logger.LogMessage("An exception occurred", exceptionFormatter);
