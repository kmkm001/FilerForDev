using System.Windows;

namespace FilerForDev
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
		/// <summary>
		/// Icon to be displayed in TaskTray.
		/// </summary>
		private NotifyIconWrapper notifyIcon;

		/// <summary>
		/// Raise an event "System.Windows.application.Startup"
		/// </summary>
		/// <param name="e"></param>
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			this.ShutdownMode = ShutdownMode.OnExplicitShutdown;
			this.notifyIcon = new NotifyIconWrapper();
		}

		/// <summary>
		/// Raise an event "System.Windows.application.Exit"
		/// </summary>
		/// <param name="e"></param>
		protected override void OnExit(ExitEventArgs e)
		{
			base.OnExit(e);

			this.notifyIcon.Dispose();
		}

    }
}
