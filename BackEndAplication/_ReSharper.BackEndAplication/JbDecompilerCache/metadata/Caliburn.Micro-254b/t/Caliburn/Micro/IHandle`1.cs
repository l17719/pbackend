// Type: Caliburn.Micro.IHandle`1
// Assembly: Caliburn.Micro, Version=1.4.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f
// Assembly location: C:\Users\joao\Documents\Visual Studio 2010\Projects\BackEndAplication\BackEndAplication\Lib\Caliburn.Micro.dll

namespace Caliburn.Micro
{
    /// <summary>
    /// Denotes a class which can handle a particular type of message.
    /// 
    /// </summary>
    /// <typeparam name="TMessage">The type of message to handle.</typeparam>
    public interface IHandle<TMessage> : IHandle
    {
        /// <summary>
        /// Handles the message.
        /// 
        /// </summary>
        /// <param name="message">The message.</param>
        void Handle(TMessage message);
    }
}
