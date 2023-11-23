using Newtonsoft.Json;
using System.Collections.Generic;

namespace HelpDesk.Common
{
    public static class JsonProvider
    {
        public static List<T>? Deserialize<T>(string fileName)
        {
            if (!FileProvider.Exist(fileName))
            {
                return default;
            }

            return JsonConvert.DeserializeObject<List<T>>(FileProvider.Get(fileName));
        }

        public static void Serialize<T>(List<T> values, string fileName)
        {
            var jsonData = JsonConvert.SerializeObject(values, Formatting.Indented);
            FileProvider.Put(fileName, jsonData);
        }
    }
}
