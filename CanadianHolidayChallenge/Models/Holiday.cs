using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianHolidayChallenge.Models
{
    class Holiday
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string NameEn { get; set; }
        public string NameFr { get; set; }
        public int Federal { get; set; }
        public string observedDate { get; set; }
        public Province[] Provinces { get; set; }

    }
}
