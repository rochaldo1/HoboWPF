using HoboConsolePrjct.Model;
using HoboConsolePrjct.Model.Hobo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HoboConsolePrjct.Data
{
    public class HoboRepository : IBaseRepository<Hobo>
    {
        protected List<Hobo> _hoboList = new();
        private string path = string.Empty;

        public HoboRepository(string path)
        {
            this.path = path;
            if (string.IsNullOrEmpty(this.path))
                throw new System.Exception("Неверный путь!");
        }
        public bool Add(Hobo hobo)
        {
            if (hobo == null || _hoboList.Contains(hobo)) return false;
            var similaryHobo = from selectHobo in _hoboList
                               where (hobo.Id == selectHobo.Id || hobo.Name == selectHobo.Name)
                               select selectHobo;
            if (similaryHobo.Count() != 0) return false;
            _hoboList.Add(hobo);
            return true;
        }

        public bool Delete(Hobo hobo)
        {
            if(hobo == null) return false;
            if (!(_hoboList.Contains(hobo))) return false;
            _hoboList.Remove(hobo);
            return true;
        }
        public bool Update(Hobo hobo)
        {
            for(int i = 0; i < _hoboList.Count; i++)
            {
                if (_hoboList[i].Id == hobo.Id)
                {
                    _hoboList[i] = hobo;
                    return true;
                }
            }
            return false;
        }

        public List<Hobo> GetHobos() => _hoboList;

        public bool Save()
        {
            if (_hoboList == null) return false;
            using var stream = File.Open(path, FileMode.Create);
            using var writer = new StreamWriter(stream);
            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string saveJson = JsonSerializer.Serialize(_hoboList, options);
            string saveJson = JsonConvert.SerializeObject(_hoboList, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
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
            _hoboList = JsonConvert.DeserializeObject<List<Hobo>>(parseJson, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
            return true;
        }

        public async Task<bool> LoadAsync()
        {
            return await Task.Run(Load);
        }
    }
}
