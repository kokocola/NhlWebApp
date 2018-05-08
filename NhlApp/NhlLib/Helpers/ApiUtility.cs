using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Helpers
{
    public static class ApiUtility
    {
        public static T GetDeserializeObject<T>(string s)
        {
            return JsonConvert.DeserializeObject<T>(StringUtility.GetStringDataFromUrl(s));
        }

        public static string SerializeObject(object item)
        {
            return JsonConvert.SerializeObject(item);
        }
    }
}
