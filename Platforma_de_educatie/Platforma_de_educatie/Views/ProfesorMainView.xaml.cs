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

namespace Platforma_de_educatie.Views
{
    /// <summary>
    /// Interaction logic for ProfesorMainView.xaml
    /// </summary>
    public partial class ProfesorMainView : Window
    {
        public ProfesorMainView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnAddTest_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnAddCourses_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnViewResults_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
