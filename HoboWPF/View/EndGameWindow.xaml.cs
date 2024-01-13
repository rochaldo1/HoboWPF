using HoboWPF.ViewModel;
using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
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

namespace HoboWPF.View
{
    /// <summary>
    /// Логика взаимодействия для EndGameWindow.xaml
    /// </summary>
    public partial class EndGameWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public EndGameWindow(IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            this.dataManager = dataManager;
            this.serviceManager = serviceManager;
            DataContext = new EndGameVM(dataManager, serviceManager);
            if(DataContext is EndGameVM endGameVM ) 
            {
                endGameVM.DeleteSucces += EndGame;
            }
        }

        private void Button_Click_Yes(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EndGame()
        {
            foreach (Window w in Application.Current.Windows)
            {
                if(w!=this)
                    w.Close();

            }
            StartWindow startWindow = new StartWindow(dataManager, serviceManager);
            startWindow.Show();
            this.Close();
        }
    }
}
