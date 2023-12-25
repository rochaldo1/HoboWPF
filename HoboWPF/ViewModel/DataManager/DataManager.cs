using HoboConsolePrjct.Data;
using HoboConsolePrjct.Model.Event;
using HoboConsolePrjct.Model.Events;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboWPF.ViewModel.DataManager
{
    class DataManager : IDataManager
    {
        private Hobo concreteHobo = null;
        private readonly HoboRepository _hoboRepository;
        private AlmsEvents _almsEvents = null;
        private readonly AlmsEventsRepository _alarmsEventsRepository;
        private DrugDen _drugDen = null;
        private readonly DrugDenRepository _drugDenRepository;
        private EstateEngency _estateEngency = null;
        private readonly EstateEngencyRepository _estateEngencyRepository;
        public GarbageEvents _garbageEvents = null;
        private readonly GarbageEventsRepository _garbageEventsRepository;
        public Hospital _hospital = null;
        private readonly HospitalRepository _hospitalRepository;
        public JobEvents _jobEvents = null;
        private readonly JobEventsRepository _jobEventsRepository;
        private readonly StoreRepository storeRepository;

        public DataManager(HoboRepository _hoboRepository)
        {
            this._hoboRepository = _hoboRepository;
 
        }

        public Hobo _concreteHobo => concreteHobo;

        public HoboRepository hoboRepository => _hoboRepository;

        public AlmsEvents almsEvents => _almsEvents;

        public AlmsEventsRepository AlmsEventsRepository => _alarmsEventsRepository;

        public DrugDen DrugDen => _drugDen;

        public DrugDenRepository DrugDenRepository => _drugDenRepository;

        public EstateEngency Engency => _estateEngency;

        public EstateEngencyRepository EstateEngencyRepository => _estateEngencyRepository;

        public GarbageEvents GarbageEvents => _garbageEvents;

        public GarbageEventsRepository GarbageEventsRepository => _garbageEventsRepository;

        public Hospital hospital => _hospital;

        public HospitalRepository HospitalRepository => _hospitalRepository;

        public JobEvents JobEvents => _jobEvents;

        public JobEventsRepository JobEventsRepository => _jobEventsRepository;

        public Task LoadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
