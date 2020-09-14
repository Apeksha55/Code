namespace Creative.Common
{
    using System;

    /// <summary>
    /// Interface ILogger
    /// </summary>
    public interface ILogger
    {
        
        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="message">The message.</param>
        /// <param name="e">The e.</param>
        void LogError( string message, Exception e);

       
    }
}