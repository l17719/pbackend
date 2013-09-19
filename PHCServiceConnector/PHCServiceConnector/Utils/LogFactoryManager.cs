using System;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace PHCServiceConnector.Utils
{
    public class LogFactoryManager:IDisposable
    {
        #region ClassVars

        private static LogFactoryManager _instance;
        private LogWriter _logFactory;
        private LogEntry _logEntry;
        #endregion

        #region Ctor

        private LogFactoryManager()
        {
            
        }

        public static LogFactoryManager GetInstance()
        {
            return _instance ?? (_instance = new LogFactoryManager());
        }
        #endregion

        #region Metodos
        /// <summary>
        /// metodos para escrever no logfile
        /// </summary>
        public void InitializeLog()
        {
            _logFactory = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();
        }

        public void WriteWarning(int valueId, string valueMessage)
        {
            _logEntry = new LogEntry
            {
                Title = "PHC WebService Warning",
                EventId = valueId,
                Message = valueMessage,
                Priority = 1,
                Severity = TraceEventType.Warning,
                MachineName = Environment.MachineName,

            };

            _logEntry.Categories.Add("Warning");
            _logFactory.Write(_logEntry);
        }

        public void WriteInfo(int valueId, string valueMessage)
        {
            _logEntry = new LogEntry
            {
                Title = "PHC WebService Warning",
                EventId = valueId,
                Message = valueMessage,
                Priority = 1,
                Severity = TraceEventType.Information,
                MachineName = Environment.MachineName,

            };

            _logEntry.Categories.Add("Warning");
            _logFactory.Write(_logEntry);
        }

        public void WriteError(int valueId, string valueMessage)
        {
            _logEntry = new LogEntry
            {
                Title = "PHC WebService Service Error",
                EventId = valueId,
                Message = valueMessage,
                Priority = -1,
                Severity = TraceEventType.Error,
                MachineName = Environment.MachineName,
            };

            _logEntry.Categories.Add("Error");
            _logFactory.Write(_logEntry);
        }
        #endregion
        #region IDisposable Methods
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
           _logFactory.Dispose();
        }
        #endregion
    }
}
