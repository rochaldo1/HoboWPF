using HoboConsolePrjct.Model.Event;
using HoboConsolePrjct.Model.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoboConsolePrjct.Data
{
    public class JobEventsRepository : IBaseRepository<JobEvents>
    {
        protected JobEvents _jobEvents;
        private string path = string.Empty;

        public JobEvents GetJobEvents() => _jobEvents;

        public JobEventsRepository(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Неверный путь!");
        }
        public bool Add(JobEvents entity)
        {
            if (entity == null) return false;
            _jobEvents = entity;
            return true;
        }

        public bool Update(JobEvents entity)
        {
            bool p = Add(entity);
            return p;
        }

        public bool Delete(JobEvents entity)
        {
            return false;
        }

        public bool Save()
        {
            if (_jobEvents == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string saveJson = JsonSerializer.Serialize(_hoboList, options);
            string saveJson = JsonConvert.SerializeObject(_jobEvents, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
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
            _jobEvents = JsonConvert.DeserializeObject<JobEvents>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
