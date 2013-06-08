using System;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace ConnectorService.Utilities
{
    public class LogFactoryManager:IDisposable
    {
        private static LogFactoryManager _instance;
        private LogWriter _logFactory;
        private LogEntry _logEntry;

        private LogFactoryManager(){}

        public static LogFactoryManager GetInstance()
        {
            return _instance ?? (_instance = new LogFactoryManager());
        }

        public void InitializeLog()
        {
            _logFactory = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();
        }

        public void WriteWarning(int valueId,string valueMessage)
        {
            _logEntry = new LogEntry
                            {
                                Title = "Connector Service Warning",
                                EventId = valueId,
                                Message = valueMessage,
                                Priority = 1,
                                Severity = TraceEventType.Warning,
                                MachineName = Environment.MachineName,
                                
                            };

            _logEntry.Categories.Add("Warning");
            _logFactory.Write(_logEntry);
        }

        public void WriteInfo(int valueId,string valueMessage)
        {
            _logEntry = new LogEntry
            {
                Title = "Connector Service Warning",
                EventId = valueId,
                Message = valueMessage,
                Priority = 1,
                Severity = TraceEventType.Information,
                MachineName = Environment.MachineName,

            };

            _logEntry.Categories.Add("Warning");
            _logFactory.Write(_logEntry);
        }

        public void WriteError(int valueId,string valueMessage)
        {
            _logEntry = new LogEntry
            {
                Title = "Connector Service Error",
                EventId = valueId,
                Message = valueMessage,
                Priority = -1,
                Severity = TraceEventType.Error,
                MachineName = Environment.MachineName,
            };

            _logEntry.Categories.Add("Error");
            _logFactory.Write(_logEntry);
        }

        #region Implementation of IDisposable

        public void Dispose()
        {
            _logFactory.Dispose();
            
            
        }

        #endregion
    }

}