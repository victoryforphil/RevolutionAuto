using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolutionCreator
{
    
    public class AutoData
    {
        //
        // JSON DATA
        //
        [JsonProperty]
        public static double FieldSize = 365.75;



        private static AutoData singleton = null;

        private AutoData() { }

        public static AutoData GetInstance()
        {
            if (singleton == null)
            {
                singleton = new AutoData();
            }
            return singleton;
        }
    }
}
