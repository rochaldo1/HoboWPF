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
using HoboWPF.ViewModel;

namespace HoboWPF.View
{
    /// <summary>
    /// Логика взаимодействия для MainHoboWindow.xaml
    /// </summary>
    public partial class MainHoboWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public MainHoboWindow(IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            DataContext = new MainHoboVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
        }
    }
}
