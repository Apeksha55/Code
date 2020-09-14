namespace Creative.Common
{
    using System;
    using System.Reflection;
    using log4net;
    using log4net.Config;

    /// <summary>
    ///     Class Log4NetLogger.
    /// </summary>
    public class Log4NetLogger : ILogger
    {
        private readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///     Initializes a new instance of the <see cref="Log4NetLogger" /> class.
        /// </summary>
        public Log4NetLogger()
        {
            XmlConfigurator.Configure();
        }

       

        /// <summary>
        ///     Logs the error.
        /// </summary>
        /// <param name="userContext">The user context.</param>
        /// <param name="message">The message.</param>
        /// <param name="e">The e.</param>
        public void LogError( string message, Exception e)
        {
            if (_log.IsDebugEnabled)
            {
                _log.Error(BuildMessage( message, e), e);
            }
            else
            {
                _log.Error(BuildMessage( message, e));
            }
        }
        
      

        /// <summary>
        ///     Builds the message.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="message">The message.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string BuildMessage( string message, Exception e)
        {
            var timeDate = String.Format("{0} : {1}",
                DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
            return String.Format("{0} | {1} | {2} | {3} | {4}{5}{6}",
                Environment.NewLine + Environment.NewLine + timeDate, message, e != null ? e.Message : string.Empty,
                Environment.NewLine, e != null ? e.StackTrace : string.Empty, Environment.NewLine, e != null ?  e.InnerException : null);
        }
    }
}