using HoboConsolePrjct.Model.Places;
using HoboConsolePrjct.Model.Event;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HoboConsolePrjct.Data
{
    public class GarbageEventsRepository : IBaseRepository<GarbageEvents>
    {
        protected GarbageEvents _garbageEvents;
        private string path = string.Empty;

        public GarbageEvents GetGarbageEvents() => _garbageEvents;

        public GarbageEventsRepository(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Неверный путь!");
        }
        public bool Add(GarbageEvents entity)
        {
            if (entity == null) return false;
            _garbageEvents = entity;
            return true;
        }

        public bool Update(GarbageEvents entity)
        {
            bool p = Add(entity);
            return p;
        }

        public bool Delete(GarbageEvents entity)
        {
            return false;
        }

        public bool Save()
        {
            if (_garbageEvents == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string saveJson = JsonSerializer.Serialize(_hoboList, options);
            string saveJson = JsonConvert.SerializeObject(_garbageEvents, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            writer.Write(saveJson);
            return true;
        }

        public async Task<bool> SaveAsync()
        {
            return await Task.Run(Save);
        }

        public bool Load()
        {
            using var stream = File.Open(path, FileMode.Open);
            using var reader = new StreamReader(stream);
            string parseJson = reader.ReadToEnd();
            if (parseJson == null) return false;
            _garbageEvents = JsonConvert.DeserializeObject<GarbageEvents>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
