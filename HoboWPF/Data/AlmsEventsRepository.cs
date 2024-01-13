using HoboConsolePrjct.Model.Events;
using Newtonsoft.Json;
using System.IO;

namespace HoboConsolePrjct.Data
{
    public class AlmsEventsRepository : IBaseRepository<AlmsEvents>
    {
        protected AlmsEvents _almsEvents;
        private string path = string.Empty;

        public AlmsEvents GetAlmsEvents() => _almsEvents;

        public AlmsEventsRepository(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Неверный путь!");
        }
        public bool Add(AlmsEvents entity)
        {
            if (entity == null) return false;
            _almsEvents = entity;
            return true;
        }

        public bool Update(AlmsEvents entity)
        {
            bool p = Add(entity);
            return p;
        }

        public bool Delete(AlmsEvents entity)
        {
            return false;
        }

        public bool Save()
        {
            if (_almsEvents == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            string saveJson = JsonConvert.SerializeObject(_almsEvents, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
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
            _almsEvents = JsonConvert.DeserializeObject<AlmsEvents>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
