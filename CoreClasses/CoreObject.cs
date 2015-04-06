using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreClasses
{
    public class CoreObject
    {
        public String TypeMessage { get; set; }
        public String Message { get; set; }
        public String TypeDestinataire { get; set; }
        public String idDestinataire { get; set; }

        public static CoreObject ConverterJsonToObject(string message)
        {
            CoreObject result = new CoreObject();

            result = JsonConvert.DeserializeObject<CoreObject>(message);

            return result;
        }

        public static string ConverterObjectToJson(CoreObject item)
        {
            var result = JsonConvert.SerializeObject(item);

            return result;
        }
    }
}
