using CanadianHolidayChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CanadianHolidayChallenge.Services
{
    class HolidayAPI : IHoliday
    {
        public static string api = "https://canada-holidays.ca/api/v1/holidays?year=2022&optional=false";

        public async Task<List<Holiday>> GetHoliday()
        {
            HttpClient client = new HttpClient();

            string json = await client.GetStringAsync(api);

            List<Holiday> holidays = JsonConvert.DeserializeObject<List<Holiday>>(json);

            return holidays;
        }
    }
}
