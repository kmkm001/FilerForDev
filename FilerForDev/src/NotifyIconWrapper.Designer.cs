namespace FilerForDev
{
	partial class NotifyIconWrapper
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconWrapper));
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "FilerForDev";
			this.notifyIcon.Visible = true;
			this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Settings,
            this.toolStripMenuItem_About,
            this.toolStripSeparator1,
            this.toolStripMenuItem_Exit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(125, 76);
			// 
			// toolStripMenuItem_Settings
			// 
			this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
			this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItem_Settings.Text = "Settings";
			// 
			// toolStripMenuItem_About
			// 
			this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
			this.toolStripMenuItem_About.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItem_About.Text = "About";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
			// 
			// toolStripMenuItem_Exit
			// 
			this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
			this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItem_Exit.Text = "Exit";
			this.contextMenuStrip.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
	}
}
