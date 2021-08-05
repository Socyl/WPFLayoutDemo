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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFLayoutDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Window window;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReplaceWindow(Window newWindow)
        {
            if (window != null)
            {
                window.Close();
                window = null;

            }
            window = newWindow;
            window.Show();
        }
        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            ReplaceWindow(new StackPanelDemo());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReplaceWindow(new WrapPanelDemo());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ReplaceWindow(new CanvasDemo());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ReplaceWindow(new DockPanelDemo());
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ReplaceWindow(new GridDemo());
        }
    }
}
