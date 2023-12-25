using HoboConsolePrjct.Data;
using HoboWPF.ViewModel.DataManager;
using System.Configuration;
using System.Data;
using System.Windows;

namespace HoboWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IDataManager dataManager;
        private AlmsEventsRepository almsEventsRepository;
        private EstateEngencyRepository estateEngencyRepository;
        private DrugDenRepository drugDenRepository;
        private GarbageEventsRepository garbageEventsRepository;
        private HoboRepository hoboRepository;
        private HospitalRepository hospitalRepository;
        private JobEventsRepository jobEventsRepository;
        private StoreRepository storeRepository;

        public App() : base()
        {
            
            string HobosPath = ConfigurationManager.AppSettings["HobosPath"] ?? string.Empty;
            string AlmsPath = ConfigurationManager.AppSettings["AlmsPath"] ?? string.Empty;
            string DrugDenPath = ConfigurationManager.AppSettings["DrugDenPath"] ?? string.Empty;
            string EstatePath = ConfigurationManager.AppSettings["EstatePath"] ?? string.Empty;
            string GarbagePath = ConfigurationManager.AppSettings["GarbagePath"] ?? string.Empty;
            string HospitalPath = ConfigurationManager.AppSettings["HospitalPath"] ?? string.Empty;
            string JobPath = ConfigurationManager.AppSettings["JobPath"] ?? string.Empty;
            string StorePath = ConfigurationManager.AppSettings["StorePath"] ?? string.Empty;


        }

    }

}
