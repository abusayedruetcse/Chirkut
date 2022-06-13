using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Chirkut.Occurrence.Columns
{
    [ColumnsScript("Occurrence.MonthlyPeriod")]
    [BasedOnRow(typeof(MonthlyPeriodRow), CheckNames = true)]
    public class MonthlyPeriodColumns
    {
        [EditLink]
        public String MonthName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Width(150)]
        public Int64 PeriodInterval { get; set; }
        [Width(150)]
        public Int64 LengthInterval { get; set; }    
    }
}