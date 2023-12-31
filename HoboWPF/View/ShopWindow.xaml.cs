﻿using HoboWPF.ViewModel;
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
    /// Логика взаимодействия для ShopWindow.xaml
    /// </summary>
    public partial class ShopWindow : Window
    {
        IDataManager dataManager;
        IServiceManager serviceManager;
        public ShopWindow(IDataManager dataManager,IServiceManager serviceManager)
        {
            InitializeComponent();
            DataContext = new ShopVM(this.dataManager = dataManager, this.serviceManager = serviceManager);
            if(DataContext is ShopVM shopVM)
            {
                shopVM.BuyFailed += OpenErrorWindow;
            }
        }
        
        private void OpenErrorWindow(string text)
        {
            ErrorWindow errorWindow = new ErrorWindow(text);
            errorWindow.ShowDialog();
        }
    }
}
