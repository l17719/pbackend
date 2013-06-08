using Caliburn.Micro;

namespace BackEndAplication.Events
{
    public class EventAggregationProvider
    {
        private static EventAggregator _eventAggregator;

        public static EventAggregator Aggregator
        {
            get { return _eventAggregator ?? (_eventAggregator = new EventAggregator()); }
        }
    }
}