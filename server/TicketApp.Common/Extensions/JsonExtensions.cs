using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TicketApp.Common.Extensions
{
    public static class JsonExtensions
    {
        public static StringContent ToJsonStringContent(this object value)
        {
            return new StringContent(JsonConvert.SerializeObject(value), Encoding.UTF8, "application/json");
        }
    }
}
