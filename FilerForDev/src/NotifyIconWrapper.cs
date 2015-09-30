using System;
using System.ComponentModel;

namespace FilerForDev
{
	/// <summary>
	/// NotifyIcon wrapper
	/// </summary>
	public partial class NotifyIconWrapper : Component
	{
		/// <summary>
		/// Main window
		/// </summary>
		private MainWindow _mainWnd;

		/// <summary>
		/// Create instance, and initialize.
		/// </summary>
		public NotifyIconWrapper()
		{
			this.InitializeComponent();

			// Set context menu event.
			this.toolStripMenuItem_Settings.Click += this.toolStripMenuItem_Settings_Click;
			this.toolStripMenuItem_About.Click += this.toolStripMenuItem_About_Click;
			this.toolStripMenuItem_Exit.Click += this.toolStripMenuItem_Exit_Click;
		}

		/// <summary>
		/// Create instance, and initialize by specify the container.
		/// </summary>
		/// <param name="container"></param>
		public NotifyIconWrapper(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		/// <summary>
		/// Event of mouse clicked NotifyIcon.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void notifyIcon_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// Run only when the left-clicked. 
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				// Show or hide MainWindow.
				this.operateMainWindowsVisible();
			}
		}

		/// <summary>
		/// Event of clicked ContextMenu "Settings".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Event of clicked ContextMenu "About".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItem_About_Click(object sender, EventArgs e)
		{
			// Create and, show VersionInfoWindow.
			VersionInfoWindow verInfoWnd = new VersionInfoWindow();
			verInfoWnd.Show();
		}

		/// <summary>
		/// Event of clicked ContextMenu "Exit".
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
		{
			// Quits the application.
			Environment.Exit(0);
		}

		/// <summary>
		/// Operate MainWindow visible.
		/// </summary>
		private void operateMainWindowsVisible()
		{
			// Create window.
			if (this._mainWnd == null)
			{
				this._mainWnd = new MainWindow();
			}
			// Show or hide window.
			if (this._mainWnd.IsVisible == false)
			{
				this._mainWnd.Show();
			}
			else
			{
				this._mainWnd.Hide();
			}
		}

	}
}
