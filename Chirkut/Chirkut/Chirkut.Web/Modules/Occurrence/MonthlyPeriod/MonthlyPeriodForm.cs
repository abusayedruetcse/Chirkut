using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Chirkut.Occurrence.Forms
{
    [FormScript("Occurrence.MonthlyPeriod")]
    [BasedOnRow(typeof(MonthlyPeriodRow), CheckNames = true)]
    public class MonthlyPeriodForm
    {
        public Int32 MonthId { get; set; }
        [HalfWidth(UntilNext = true)]
        public DateTime StartDate { get; set; }
        public Int64 PeriodInterval { get; set; }
        public DateTime EndDate { get; set; }
        public Int64 LengthInterval { get; set; }
        [FullWidth]
        [HtmlNoteContentEditor]
        public String Description { get; set; }
    }
}