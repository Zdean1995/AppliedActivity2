using CanadianHolidayChallenge.Models;
using CanadianHolidayChallenge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianHolidayChallenge.ViewModels
{
    internal class HolidayViewModel
    {
        public string APIText = "";
        async Task GetHolidays()
        {
            var holidayService = DependencyService.Get<IHoliday>();
            List<Holiday> Holidays = await holidayService.GetHoliday();

            foreach(Holiday holiday in Holidays)
            {
                APIText += holiday.NameEn;
            }
        }

        public HolidayViewModel()
        {
            GetHolidays();
        }
    }
}
