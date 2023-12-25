using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoboConsolePrjct.Data;
using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.Events;
using HoboConsolePrjct.Model.Places;
using HoboConsolePrjct.Model.Event;

namespace HoboWPF.ViewModel.DataManager
{
    public interface IDataManager
    {
        public Hobo _concreteHobo { get; }
        public HoboRepository hoboRepository { get; }
        public AlmsEvents almsEvents { get; }
        public AlmsEventsRepository AlmsEventsRepository { get; }
        public DrugDen DrugDen { get; }
        public DrugDenRepository DrugDenRepository { get; }
        public EstateEngency Engency { get; }
        public EstateEngencyRepository EstateEngencyRepository { get; }
        public GarbageEvents GarbageEvents { get; }
        public GarbageEventsRepository GarbageEventsRepository { get; }
        public Hospital hospital { get; }
        public HospitalRepository HospitalRepository { get; }

        public JobEvents JobEvents { get; }
        public JobEventsRepository JobEventsRepository { get; }

        public Task SaveAllAsync();
        public Task LoadAllAsync();
    }
}
