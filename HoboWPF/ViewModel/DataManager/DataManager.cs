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
        private IEvents concreteEvent;
        private Hobo concreteHobo = null;
        private readonly HoboRepository _hoboRepository;
        private AlmsEvents _almsEvents = null;
        private readonly AlmsEventsRepository _almsEventsRepository;
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
        public Stores _stores;
        private readonly StoreRepository _storeRepository;

        public DataManager(HoboRepository _hoboRepository, AlmsEventsRepository _almsEventsRepository, DrugDenRepository _drugDenRepository, EstateEngencyRepository _estateEngencyRepository,GarbageEventsRepository _garbageEventsRepository, HospitalRepository _hospitalRepository, JobEventsRepository _jobEventsRepository,StoreRepository _storeRepository )
        {
            this._hoboRepository = _hoboRepository;
            this._almsEventsRepository = _almsEventsRepository;
            this._drugDenRepository = _drugDenRepository;
            this._estateEngencyRepository = _estateEngencyRepository;
            this._garbageEventsRepository = _garbageEventsRepository;
            this._hospitalRepository = _hospitalRepository;
            this._jobEventsRepository = _jobEventsRepository;
            this._storeRepository = _storeRepository;
        }
        public static DataManager Instance(HoboRepository _hoboRepository, AlmsEventsRepository _almsEventsRepository, DrugDenRepository _drugDenRepository, EstateEngencyRepository _estateEngencyRepository, GarbageEventsRepository _garbageEventsRepository, HospitalRepository _hospitalRepository, JobEventsRepository _jobEventsRepository, StoreRepository _storeRepository) => new(_hoboRepository, _almsEventsRepository, _drugDenRepository, _estateEngencyRepository, _garbageEventsRepository, _hospitalRepository, _jobEventsRepository, _storeRepository);

        public Hobo _concreteHobo
        {
            get => concreteHobo;
            set
            {
                if(value != null)
                    concreteHobo = value;
            }
        }

        public HoboRepository hoboRepository => _hoboRepository;

        public AlmsEvents almsEvents
        {
            get => _almsEventsRepository.GetAlmsEvents();   
        }

        public IEvents ConcreteEvent
        {
            get => concreteEvent;
            set => concreteEvent = value;
        }

        public AlmsEventsRepository AlmsEventsRepository => _almsEventsRepository;

        public DrugDen DrugDen
        {
            get => DrugDenRepository.GetDrugDen();
        }

        public DrugDenRepository DrugDenRepository => _drugDenRepository;

        public EstateEngency Engency
        {
            get => EstateEngencyRepository.GetEstateEngency();
        }

        public EstateEngencyRepository EstateEngencyRepository => _estateEngencyRepository;

        public GarbageEvents GarbageEvents
        {
            get =>  _garbageEventsRepository.GetGarbageEvents();
        }

        public GarbageEventsRepository GarbageEventsRepository => _garbageEventsRepository;

        public Hospital hospital
        {
            get => HospitalRepository.GetHospital();
        }

        public HospitalRepository HospitalRepository => _hospitalRepository;

        public JobEvents JobEvents
        {
            get => _jobEventsRepository.GetJobEvents();
        }

        public JobEventsRepository JobEventsRepository => _jobEventsRepository;

        public Stores Stores
        {
            get => _stores = StoreRepository.GetStores();
        }
        public StoreRepository StoreRepository => _storeRepository;

        public async Task LoadHobosAsync()
        {
            await _hoboRepository.LoadAsync();
        }
        public async Task LoadAlmsAsync()
        {
            await _almsEventsRepository.LoadAsync();
        }
        public async Task LoadDrugDenAsync()
        {
            await _drugDenRepository.LoadAsync();
        }
        public async Task LoadEgencyAsync()
        {
            await _estateEngencyRepository.LoadAsync();
        }
        public async Task LoadGarbageAsync()
        {
            await _garbageEventsRepository.LoadAsync();
        }
        public async Task LoadHospitalDenAsync()
        {
            await _hospitalRepository.LoadAsync();
        }
        public async Task LoadJobAsync()
        {
            await _jobEventsRepository.LoadAsync();
        }
        public async Task LoadStoreAsync()
        {
            await _storeRepository.LoadAsync();
        }


        public async Task SaveHobosAsync()
        {
            await _hoboRepository.SaveAsync();
        }
        public async Task SaveAlmsAsync()
        {
            await _almsEventsRepository.SaveAsync();
        }
        public async Task SaveDrugDenAsync()
        {
            await _drugDenRepository.SaveAsync();
        }
        public async Task SaveEgencyAsync()
        {
            await _estateEngencyRepository.SaveAsync();
        }
        public async Task SaveGarbageAsync()
        {
            await _garbageEventsRepository.SaveAsync();
        }
        public async Task SaveHospitalDenAsync()
        {
            await _hospitalRepository.SaveAsync();
        }
        public async Task SaveJobAsync()
        {
            await _jobEventsRepository.SaveAsync();
        }
        public async Task SaveStoreAsync()
        {
            await _storeRepository.SaveAsync();
        }
    }
}
