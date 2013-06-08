using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;

namespace BackEndAplication.Utilities
{
    public class LogFactoryManager
    {
        private static LogFactoryManager _instance;
        private LogEntry _logEntry;
        private LogWriter _logFactory;

        private LogFactoryManager()
        {
        }

        public static LogFactoryManager GetInstance()
        {
            return _instance ?? (_instance = new LogFactoryManager());
        }

        public void InitializeLog()
        {
            _logFactory = EnterpriseLibraryContainer.Current.GetInstance<LogWriter>();
        }


        public void WriteWarning(int valueEventId, string valueMessage)
        {
            _logEntry = new LogEntry
                            {
                                Title = "BackEndApplication Warning",
                                EventId = valueEventId,
                                Message = valueMessage,
                                Priority = 1,
                                Severity = TraceEventType.Warning
                            };
            _logEntry.Categories.Add("Warning");
            _logFactory.Write(_logEntry);
        }


        public void WriteInfo(int valueEventId, string valueMessage)
        {
            _logEntry = new LogEntry
                            {
                                Title = "BackEndApplication Information",
                                EventId = valueEventId,
                                Message = valueMessage,
                                Priority = 2,
                                Severity = TraceEventType.Information,
                            };

            _logEntry.Categories.Add("Information");
            _logFactory.Write(_logEntry);
        }


        public void WriteError(int valueEventId, string valueMessage)
        {
            _logEntry = new LogEntry
                            {
                                EventId = valueEventId,
                                Message = valueMessage,
                                Priority = -1,
                                Severity = TraceEventType.Error
                            };

            _logEntry.Categories.Add("Error");
            _logFactory.Write(_logEntry);
        }


        //public void EventViewerCheckSource()
        //{
        //    if (!EventLog.SourceExists("BackEndSource"))
        //    {
        //        EventLog.CreateEventSource("BackEndSource", "BackendLog");
        //    }
        //}
    }
}