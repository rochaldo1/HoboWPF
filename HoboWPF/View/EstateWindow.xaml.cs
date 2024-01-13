using HoboWPF.ViewModel.DataManager;
using HoboWPF.ViewModel.Services;
using HoboWPF.ViewModel;
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
    /// Логика взаимодействия для EstateWindow.xaml
    /// </summary>
    public partial class EstateWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public EstateWindow(IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            DataContext = new EstateVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
            if (DataContext is EstateVM estateVM)
            {
                estateVM.BuyFailed += OpenErrorWindow;
                estateVM.BuyHouse += OpenEndWindow;
            }
        }

        private void OpenErrorWindow(string text)
        {
            ErrorWindow errorWindow = new ErrorWindow(text);
            errorWindow.ShowDialog();
        }

        private void OpenEndWindow()
        {
            EndGameWindow endGameWindow = new EndGameWindow(dataManager,serviceManager);
            endGameWindow.ShowDialog();
        }
    }
}
