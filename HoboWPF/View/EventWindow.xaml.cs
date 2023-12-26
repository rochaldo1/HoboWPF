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
    /// Логика взаимодействия для EventWindow.xaml
    /// </summary>
    public partial class EventWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public EventWindow(IDataManager dataManager, IServiceManager serviceManager)
        {
            InitializeComponent();
            DataContext = new EventVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
        }

        private void Succes_Event_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
