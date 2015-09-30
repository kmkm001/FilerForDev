using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
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
