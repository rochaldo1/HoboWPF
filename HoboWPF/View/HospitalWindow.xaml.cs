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
using HoboConsolePrjct.Model.Places;

namespace HoboWPF.View
{
    /// <summary>
    /// Логика взаимодействия для HospitalWindow.xaml
    /// </summary>
    public partial class HospitalWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public HospitalWindow(IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            DataContext = new HospitalVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
            if (DataContext is HospitalVM hospitalVM)
            {
                hospitalVM.BuyFailed += OpenErrorWindow;
            }
        }

        private void OpenErrorWindow(string text)
        {
            ErrorWindow errorWindow = new ErrorWindow(text);
            errorWindow.ShowDialog();
        }
    }
}
