using HoboConsolePrjct.Model.Places;
using Newtonsoft.Json;
using System.IO;

namespace HoboConsolePrjct.Data
{
    public class EstateEngencyRepository : IBaseRepository<EstateEngency>
    {
        protected EstateEngency _estateEngency;
        private string path = string.Empty;

        public EstateEngency GetEstateEngency() => _estateEngency;

        public EstateEngencyRepository(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Неверный путь!");
        }
        public bool Add(EstateEngency entity)
        {
            if (entity == null) return false;
            _estateEngency = entity;
            return true;
        }

        public bool Update(EstateEngency entity)
        {
            bool p = Add(entity);
            return p;
        }

        public bool Delete(EstateEngency entity)
        {
            return false;
        }

        public bool Save()
        {
            if (_estateEngency == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            string saveJson = JsonConvert.SerializeObject(_estateEngency, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
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
            _estateEngency = JsonConvert.DeserializeObject<EstateEngency>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
