using System;
using System.Collections.Generic;

namespace AFM_Project.Models
{
    public partial class Holidays
    {
        public int IdHolidays { get; set; }
        public DateTime? HolidayDate { get; set; }
        public string HolidayLabel { get; set; }
    }
}
