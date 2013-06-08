using System;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace BackEndAplication.Utilities
{
    public class ShowDialog<T> : IResult
    {
        private Action<T> _initialization = x => { };

        [Import]
        public IWindowManager Window { get; set; }

        public T Dialog { get; private set; }

        #region IResult Members

        public event EventHandler<ResultCompletionEventArgs> Completed = delegate { };


        public void Execute(ActionExecutionContext valueContext)
        {
            var screen = IoC.Get<T>();

            _initialization.Invoke(screen);

            Dialog = screen;
            Window.ShowDialog(screen);

            var deactivated = screen as IDeactivate;
            if (deactivated == null)
            {
                Completed(this, new ResultCompletionEventArgs());
            }
            else
            {
                deactivated.Deactivated += (o, e) =>
                                               {
                                                   if (e.WasClosed)
                                                   {
                                                       Completed(this, new ResultCompletionEventArgs());
                                                   }
                                               };
            }
        }

        #endregion

        public ShowDialog<T> ConfigureWith(Action<T> iAction, Action<T> valueAction = null)
        {
            _initialization = iAction;
            return this;
        }
    }
}