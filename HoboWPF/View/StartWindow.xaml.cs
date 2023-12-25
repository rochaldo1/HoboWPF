﻿using HoboWPF.ViewModel.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HoboWPF.ViewModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HoboWPF.ViewModel.Services;

namespace HoboWPF.View
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public StartWindow(IDataManager dataManager,IServiceManager serviceManager)
        {
            InitializeComponent();
            DataContext = new StartVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
            if(DataContext is StartVM startVM)
            {
                startVM.TakeHoboSucces += OpenMainHoboWindow;
                
            }
        }

        private void OpenMainHoboWindow()
        {
            MainHoboWindow mainHoboWindow = new MainHoboWindow(dataManager, serviceManager);
            mainHoboWindow.Show();
            this.Close();
        }
    }
}
