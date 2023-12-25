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
    public class HospitalRepository : IBaseRepository<Hospital>
    {
        protected Hospital _hospital;
        private string path = string.Empty;

        public Hospital GetHospital() => _hospital;

        public HospitalRepository(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Неверный путь!");
        }
        public bool Add(Hospital entity)
        {
            if (entity == null) return false;
            _hospital = entity;
            return true;
        }

        public bool Update(Hospital entity)
        {
            bool p = Add(entity);
            return p;
        }

        public bool Delete(Hospital entity)
        {
            return false;
        }

        public bool Save()
        {
            if (_hospital == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string saveJson = JsonSerializer.Serialize(_hoboList, options);
            string saveJson = JsonConvert.SerializeObject(_hospital, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
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
            _hospital = JsonConvert.DeserializeObject<Hospital>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
