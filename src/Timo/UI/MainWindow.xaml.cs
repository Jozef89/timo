using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Timo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
		}

        // Move window
        private void Background_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        // Close window
        private void btnClose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
			grdLeftPanel.Visibility = Visibility.Collapsed;
			grdEsc.Visibility = Visibility.Visible;
            //this.Close();
        }
	}
}