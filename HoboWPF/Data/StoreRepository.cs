using HoboConsolePrjct.Model.Hobo;
using HoboConsolePrjct.Model.Places;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HoboConsolePrjct.Data
{
    public class StoreRepository : IBaseRepository<Stores>
    {
        protected Stores _store;
        private string path = string.Empty;

        public StoreRepository(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Неверный путь!");
        }
        public bool Add(Stores entity)
        {
            if (entity == null) return false;
            _store = entity;
            return true;
        }
        public Stores GetStores() => _store;
        public bool Update(Stores entity)
        {
            bool p = Add(entity);
            return p;
        }

        public bool Delete(Stores entity)
        {
            return false;
        }

        public bool Save()
        {
            if (_store == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string saveJson = JsonSerializer.Serialize(_hoboList, options);
            string saveJson = JsonConvert.SerializeObject(_store, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
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
            _store = JsonConvert.DeserializeObject<Stores>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
