using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Assets.Scripts
{
    public class ConfigDeserialaizer<T>
    {
        public Dictionary<int,T> GetDictionary(string path)
        {
            return JsonConvert.DeserializeObject<Dictionary<int, T>>(File.ReadAllText(path, Encoding.UTF8));
        }
        public T GetObject(string path)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path, Encoding.UTF8));
        }
    }
}
