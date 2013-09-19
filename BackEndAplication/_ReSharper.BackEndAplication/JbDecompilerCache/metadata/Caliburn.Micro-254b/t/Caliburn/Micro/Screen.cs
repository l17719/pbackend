// Type: Caliburn.Micro.Screen
// Assembly: Caliburn.Micro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Users\joao\Documents\Visual Studio 2010\Projects\BackEndAplication\BackEndAplication\Lib\Caliburn.Micro.dll

using System;
using System.ComponentModel;

namespace Caliburn.Micro
{
    public class Screen : PropertyChangedBase, IScreen, IHaveDisplayName, IActivate, IDeactivate, IGuardClose, INotifyPropertyChangedEx, INotifyPropertyChanged, IChild<IConductor>, IViewAware
    {
        protected static readonly ILog Log;
        public Screen();
        void IActivate.Activate();
        protected virtual void OnInitialize();
        protected virtual void OnActivate();
        void IDeactivate.Deactivate(bool close);
        protected virtual void OnDeactivate(bool close);
        public virtual void CanClose(Action<bool> callback);
        public virtual void AttachView(object view, object context = null);
        protected virtual void OnViewLoaded(object view);
        public virtual object GetView(object context = null);
        public void TryClose();
        public IConductor Parent { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; private set; }
        public bool IsInitialized { get; private set; }
        public event EventHandler<ActivationEventArgs> Activated;
        public event EventHandler<DeactivationEventArgs> Deactivated;
    }
}
