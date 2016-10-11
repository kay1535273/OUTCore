using System.Reflection;
using log4net;

namespace OUTCore.Diagnostics
{
    /// <summary>
    /// Represents the base class of all loggers in the OutCore framework.
    /// </summary>
    public sealed class Logger
    {
        /// <summary>
        /// The Log4Net 4 net logging interface.
        /// </summary>
        private static readonly ILog Log4Net;

        /// <summary>
        /// Initialises a new instance of the OUTCore.Bll.Services.Diagnostics.Logger class.
        /// </summary>
        static Logger()
        {
            Log4Net = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="logType">The type of message to Log4Net.</param>
        /// <param name="message">The message or message format to Log4Net.</param>
        /// <param name="messageFormatArguments">The message format arguments.</param>
        public static void Log(LogType logType, string message, params object[] messageFormatArguments)
        {
            // Determine the type of message being logged
            switch (logType)
            {
                // Debug
                case LogType.Debug:
                    if (messageFormatArguments != null && messageFormatArguments.Length > 0)
                        Log4Net.DebugFormat(message, messageFormatArguments);
                    else
                        Log4Net.Debug(message);
                    break;

                // Warning
                case LogType.Warning:
                    if (messageFormatArguments != null && messageFormatArguments.Length > 0)
                        Log4Net.WarnFormat(message, messageFormatArguments);
                    else
                        Log4Net.Warn(message);
                    break;

                // Error
                case LogType.Error:
                    if (messageFormatArguments != null && messageFormatArguments.Length > 0)
                        Log4Net.ErrorFormat(message, messageFormatArguments);
                    else
                        Log4Net.Error(message);
                    break;

                // Fatal
                case LogType.Fatal:
                    if (messageFormatArguments != null && messageFormatArguments.Length > 0)
                        Log4Net.FatalFormat(message, messageFormatArguments);
                    else
                        Log4Net.Fatal(message);
                    break;

                // Info or anything else not handled
                default:
                    if (messageFormatArguments != null && messageFormatArguments.Length > 0)
                        Log4Net.InfoFormat(message, messageFormatArguments);
                    else
                        Log4Net.Info(message);
                    break;
            }
        }
    }
}
