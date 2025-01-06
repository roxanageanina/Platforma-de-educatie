using Platforma_de_educatie.Models;
using Platforma_de_educatie.Repositories;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Platforma_de_educatie.Views
{
    public partial class SelectTestView : Window
    {
        private readonly TestRepository _testRepository;

        public SelectTestView()
        {
            InitializeComponent();
            _testRepository = new TestRepository();
            LoadTests();
        }

        private void LoadTests()
        {
            IEnumerable<TestModel> tests = _testRepository.GetAvailableTests();
            TestListBox.ItemsSource = tests;
        }

        private void OnContinueClick(object sender, RoutedEventArgs e)
        {
            if (TestListBox.SelectedItem is TestModel selectedTest)
            {
                MessageBox.Show("Urmeaza sa implementam!", "Atenție", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("Te rog să selectezi un test înainte de a continua!", "Atenție", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }
    }
}
