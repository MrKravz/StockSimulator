using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Assets.Scripts.Serializers
{
    public class ConfigSerializer<T>
    {
        public void WtiteDictionary(string path, Dictionary<int,T> list)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(list));
        }
        public void WriteObject(string path, T obj)
        {
           File.WriteAllText(path,JsonConvert.SerializeObject(obj));
        }
    }
}
