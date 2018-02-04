using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OpsMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var values = e;
                Process.Start((sender as Hyperlink).NavigateUri.LocalPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open {(sender as Hyperlink).NavigateUri.LocalPath}", "Error");
            }
        }


        private void UIElement_OnGotMouseCapture(object sender, MouseEventArgs e)
        {
            var ee = e;
        }

        private void UIElement_OnGotFocus(object sender, RoutedEventArgs e)
        {
            var ee = e;
        }

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            var ee = e;
        }

    }
}
