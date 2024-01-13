using HoboConsolePrjct.Model.Places;
using Newtonsoft.Json;
using System.IO;

namespace HoboConsolePrjct.Data
{
    public class DrugDenRepository : IBaseRepository<DrugDen>
    {
        protected DrugDen _drugDen;
        private string path = string.Empty;

        public DrugDen GetDrugDen() => _drugDen;

        public DrugDenRepository(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Неверный путь!");
        }
        public bool Add(DrugDen entity)
        {
            if (entity == null) return false;
            _drugDen = entity;
            return true;
        }

        public bool Update(DrugDen entity)
        {
            bool p = Add(entity);
            return p;
        }

        public bool Delete(DrugDen entity)
        {
            return false;
        }

        public bool Save()
        {
            if (_drugDen == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            string saveJson = JsonConvert.SerializeObject(_drugDen, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
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
            _drugDen = JsonConvert.DeserializeObject<DrugDen>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
