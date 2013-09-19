// Type: Caliburn.Micro.Bootstrapper
// Assembly: Caliburn.Micro, Version=1.3.1.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f
// Assembly location: C:\Users\joao\Documents\Visual Studio 2010\Projects\BackEndAplication\BackEndAplication\Lib\Caliburn.Micro.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;

namespace Caliburn.Micro
{
    /// <summary>
    /// Instantiate this class in order to configure the framework.
    /// 
    /// </summary>
    public class Bootstrapper
    {
        /// <summary>
        /// Creates an instance of the bootstrapper.
        /// 
        /// </summary>
        /// <param name="useApplication">Set this to false when hosting Caliburn.Micro inside and Office or WinForms application. The default is true.</param>
        public Bootstrapper(bool useApplication = true);

        /// <summary>
        /// Called by the bootstrapper's constructor at design time to start the framework.
        /// 
        /// </summary>
        protected virtual void StartDesignTime();

        /// <summary>
        /// Called by the bootstrapper's constructor at runtime to start the framework.
        /// 
        /// </summary>
        protected virtual void StartRuntime();

        /// <summary>
        /// Provides an opportunity to hook into the application object.
        /// 
        /// </summary>
        protected virtual void PrepareApplication();

        /// <summary>
        /// Override to configure the framework and setup your IoC container.
        /// 
        /// </summary>
        protected virtual void Configure();

        /// <summary>
        /// Override to tell the framework where to find assemblies to inspect for views, etc.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// A list of assemblies to inspect.
        /// </returns>
        protected virtual IEnumerable<Assembly> SelectAssemblies();

        /// <summary>
        /// Override this to provide an IoC specific implementation.
        /// 
        /// </summary>
        /// <param name="service">The service to locate.</param><param name="key">The key to locate.</param>
        /// <returns>
        /// The located service.
        /// </returns>
        protected virtual object GetInstance(Type service, string key);

        /// <summary>
        /// Override this to provide an IoC specific implementation
        /// 
        /// </summary>
        /// <param name="service">The service to locate.</param>
        /// <returns>
        /// The located services.
        /// </returns>
        protected virtual IEnumerable<object> GetAllInstances(Type service);

        /// <summary>
        /// Override this to provide an IoC specific implementation.
        /// 
        /// </summary>
        /// <param name="instance">The instance to perform injection on.</param>
        protected virtual void BuildUp(object instance);

        /// <summary>
        /// Override this to add custom behavior to execute after the application starts.
        /// 
        /// </summary>
        /// <param name="sender">The sender.</param><param name="e">The args.</param>
        protected virtual void OnStartup(object sender, StartupEventArgs e);

        /// <summary>
        /// Override this to add custom behavior on exit.
        /// 
        /// </summary>
        /// <param name="sender">The sender.</param><param name="e">The event args.</param>
        protected virtual void OnExit(object sender, EventArgs e);

        /// <summary>
        /// Override this to add custom behavior for unhandled exceptions.
        /// 
        /// </summary>
        /// <param name="sender">The sender.</param><param name="e">The event args.</param>
        protected virtual void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e);

        /// <summary>
        /// Locates the view model, locates the associate view, binds them and shows it as the root view.
        /// 
        /// </summary>
        /// <param name="viewModelType">The view model type.</param>
        protected static void DisplayRootViewFor(Type viewModelType);

        /// <summary>
        /// The application.
        /// 
        /// </summary>
        protected Application Application { get; set; }
    }
}
