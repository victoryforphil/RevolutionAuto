using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace RevolutionCreator
{
    class AutoFileManager
    {
        public static string ConvertToJSON()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            settings.Formatting = Formatting.Indented;
            AutoData data = AutoData.GetInstance();
            string jsonText = JsonConvert.SerializeObject(AutoData.GetInstance(), settings);

            return jsonText;
        }
    }
}
