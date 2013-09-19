// Type: Caliburn.Micro.ConductorBaseWithActiveItem`1
// Assembly: Caliburn.Micro, Version=1.4.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f
// Assembly location: C:\Users\joao\Documents\Visual Studio 2010\Projects\BackEndAplication\BackEndAplication\Lib\Caliburn.Micro.dll

using System.ComponentModel;

namespace Caliburn.Micro
{
    /// <summary>
    /// A base class for various implementations of <see cref="T:Caliburn.Micro.IConductor"/> that maintain an active item.
    /// 
    /// </summary>
    /// <typeparam name="T">The type that is being conducted.</typeparam>
    public abstract class ConductorBaseWithActiveItem<T> : ConductorBase<T>, IConductActiveItem, IConductor, IParent, INotifyPropertyChangedEx, INotifyPropertyChanged, IHaveActiveItem
    {
        /// <summary>
        /// Changes the active item.
        /// 
        /// </summary>
        /// <param name="newItem">The new item to activate.</param><param name="closePrevious">Indicates whether or not to close the previous active item.</param>
        protected virtual void ChangeActiveItem(T newItem, bool closePrevious);

        /// <summary>
        /// The currently active item.
        /// 
        /// </summary>
        public T ActiveItem { get; set; }

        /// <summary>
        /// The currently active item.
        /// 
        /// </summary>
        /// 
        /// <value/>
        object IHaveActiveItem.ActiveItem { get; set; }
    }
}
