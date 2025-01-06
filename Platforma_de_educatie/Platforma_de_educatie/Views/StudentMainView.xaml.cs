using Platforma_de_educatie.Models;
using Platforma_de_educatie.ViewModels;
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
using Platforma_de_educatie.Repositories;
using Platforma_de_educatie.Views;

namespace Platforma_de_educatie.Views
{
    /// <summary>
    /// Interaction logic for StudentMainPage.xaml
    /// </summary>
    public partial class StudentMainView : Window
    {
        public StudentMainView()
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

        private void btnTakeTest_Click(object sender, RoutedEventArgs e)
        {
            var selectTestView = new SelectTestView();
            this.Close();
            selectTestView.ShowDialog();
        }

        private void btnAccessCourses_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}


