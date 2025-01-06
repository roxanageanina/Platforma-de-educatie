using Platforma_de_educatie.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Platforma_de_educatie.Views;
using Platforma_de_educatie.Repositories;
using System.Threading;

namespace Platforma_de_educatie
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var loginView = new LoginView();
            loginView.Show();
            loginView.IsVisibleChanged += (s, ev) =>
            {
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {
                    var userRepository = new UserRepository();
                    var currentUser = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);

                    if (currentUser != null)
                    {
                        Window mainView = null;

                        switch (currentUser.AccountType)
                        {
                            case "Administrator":
                                mainView = new AdminMainView();
                                break;
                            case "Profesor":
                                mainView = new ProfesorMainView();
                                break;
                            case "Student":
                                mainView = new StudentMainView();
                                break;
                            default:
                                MessageBox.Show("Tip de cont necunoscut!", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
                                Application.Current.Shutdown();
                                return;
                        }

                        mainView?.Show();
                        loginView.Close();
                    }
                    else
                    {
                        MessageBox.Show("Autentificare eșuată. Utilizator invalid!", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
                        loginView.Show();
                    }
                }
            };
        }
    }
}
