using System.Windows;
using VersionInformation;

namespace FilerForDev
{
	/// <summary>
	/// VersionInfoWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class VersionInfoWindow : Window
	{
		public VersionInfoWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			string productName = VersionInfo.GetVersionInfo(VersionInfo.VerInfo.PRODUCTNAME);
			string productVersion = VersionInfo.GetVersionInfo(VersionInfo.VerInfo.PRODUCTVERSION);

			this.labelName.Content = productName;
			this.labelVersion.Content = productVersion;
		}
	}
}
