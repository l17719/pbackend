// Type: Caliburn.Micro.Conductor`1
// Assembly: Caliburn.Micro, Version=1.4.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f
// Assembly location: C:\Users\joao\Documents\Visual Studio 2010\Projects\BackEndAplication\BackEndAplication\Lib\Caliburn.Micro.dll

using System;
using System.Collections.Generic;

namespace Caliburn.Micro
{
    /// <summary>
    /// An implementation of <see cref="T:Caliburn.Micro.IConductor"/> that holds on to and activates only one item at a time.
    /// 
    /// </summary>
    public class Conductor<T> : ConductorBaseWithActiveItem<T>
    {
        /// <summary>
        /// Activates the specified item.
        /// 
        /// </summary>
        /// <param name="item">The item to activate.</param>
        public override void ActivateItem(T item);

        /// <summary>
        /// Deactivates the specified item.
        /// 
        /// </summary>
        /// <param name="item">The item to close.</param><param name="close">Indicates whether or not to close the item after deactivating it.</param>
        public override void DeactivateItem(T item, bool close);

        /// <summary>
        /// Called to check whether or not this instance can close.
        /// 
        /// </summary>
        /// <param name="callback">The implementor calls this action with the result of the close check.</param>
        public override void CanClose(Action<bool> callback);

        /// <summary>
        /// Called when activating.
        /// 
        /// </summary>
        protected override void OnActivate();

        /// <summary>
        /// Called when deactivating.
        /// 
        /// </summary>
        /// <param name="close">Inidicates whether this instance will be closed.</param>
        protected override void OnDeactivate(bool close);

        /// <summary>
        /// Gets the children.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// The collection of children.
        /// </returns>
        public override IEnumerable<T> GetChildren();

        /// <summary>
        /// An implementation of <see cref="T:Caliburn.Micro.IConductor"/> that holds on many items.
        /// 
        /// </summary>
        /// 
        /// <summary>
        /// An implementation of <see cref="T:Caliburn.Micro.IConductor"/> that holds on many items.
        /// 
        /// </summary>
        public class Collection
        {
            /// <summary>
            /// An implementation of <see cref="T:Caliburn.Micro.IConductor"/> that holds on to many items wich are all activated.
            /// 
            /// </summary>
            public class AllActive : ConductorBase<T>
            {
                /// <summary>
                /// Initializes a new instance of the <see cref="T:Caliburn.Micro.Conductor`1.Collection.AllActive"/> class.
                /// 
                /// </summary>
                /// <param name="openPublicItems">if set to <c>true</c> opens public items that are properties of this class.</param>
                public AllActive(bool openPublicItems);

                /// <summary>
                /// Initializes a new instance of the <see cref="T:Caliburn.Micro.Conductor`1.Collection.AllActive"/> class.
                /// 
                /// </summary>
                public AllActive();

                /// <summary>
                /// Called when activating.
                /// 
                /// </summary>
                protected override void OnActivate();

                /// <summary>
                /// Called when deactivating.
                /// 
                /// </summary>
                /// <param name="close">Inidicates whether this instance will be closed.</param>
                protected override void OnDeactivate(bool close);

                /// <summary>
                /// Called to check whether or not this instance can close.
                /// 
                /// </summary>
                /// <param name="callback">The implementor calls this action with the result of the close check.</param>
                public override void CanClose(Action<bool> callback);

                /// <summary>
                /// Called when initializing.
                /// 
                /// </summary>
                protected override void OnInitialize();

                /// <summary>
                /// Activates the specified item.
                /// 
                /// </summary>
                /// <param name="item">The item to activate.</param>
                public override void ActivateItem(T item);

                /// <summary>
                /// Deactivates the specified item.
                /// 
                /// </summary>
                /// <param name="item">The item to close.</param><param name="close">Indicates whether or not to close the item after deactivating it.</param>
                public override void DeactivateItem(T item, bool close);

                /// <summary>
                /// Gets the children.
                /// 
                /// </summary>
                /// 
                /// <returns>
                /// The collection of children.
                /// </returns>
                public override IEnumerable<T> GetChildren();

                /// <summary>
                /// Ensures that an item is ready to be activated.
                /// 
                /// </summary>
                /// <param name="newItem"/>
                /// <returns>
                /// The item to be activated.
                /// </returns>
                protected override T EnsureItem(T newItem);

                /// <summary>
                /// Gets the items that are currently being conducted.
                /// 
                /// </summary>
                public IObservableCollection<T> Items { get; }
            }

            /// <summary>
            /// An implementation of <see cref="T:Caliburn.Micro.IConductor"/> that holds on many items but only activates on at a time.
            /// 
            /// </summary>
            public class OneActive : ConductorBaseWithActiveItem<T>
            {
                /// <summary>
                /// Gets the children.
                /// 
                /// </summary>
                /// 
                /// <returns>
                /// The collection of children.
                /// </returns>
                public override IEnumerable<T> GetChildren();

                /// <summary>
                /// Activates the specified item.
                /// 
                /// </summary>
                /// <param name="item">The item to activate.</param>
                public override void ActivateItem(T item);

                /// <summary>
                /// Deactivates the specified item.
                /// 
                /// </summary>
                /// <param name="item">The item to close.</param><param name="close">Indicates whether or not to close the item after deactivating it.</param>
                public override void DeactivateItem(T item, bool close);

                /// <summary>
                /// Determines the next item to activate based on the last active index.
                /// 
                /// </summary>
                /// <param name="list">The list of possible active items.</param><param name="lastIndex">The index of the last active item.</param>
                /// <returns>
                /// The next item to activate.
                /// </returns>
                /// 
                /// <remarks>
                /// Called after an active item is closed.
                /// </remarks>
                protected virtual T DetermineNextItemToActivate(IList<T> list, int lastIndex);

                /// <summary>
                /// Called to check whether or not this instance can close.
                /// 
                /// </summary>
                /// <param name="callback">The implementor calls this action with the result of the close check.</param>
                public override void CanClose(Action<bool> callback);

                /// <summary>
                /// Called when activating.
                /// 
                /// </summary>
                protected override void OnActivate();

                /// <summary>
                /// Called when deactivating.
                /// 
                /// </summary>
                /// <param name="close">Inidicates whether this instance will be closed.</param>
                protected override void OnDeactivate(bool close);

                /// <summary>
                /// Ensures that an item is ready to be activated.
                /// 
                /// </summary>
                /// <param name="newItem"/>
                /// <returns>
                /// The item to be activated.
                /// </returns>
                protected override T EnsureItem(T newItem);

                /// <summary>
                /// Gets the items that are currently being conducted.
                /// 
                /// </summary>
                public IObservableCollection<T> Items { get; }
            }
        }
    }
}
