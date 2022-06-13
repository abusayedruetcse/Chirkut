using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Chirkut.AdminModule.Columns
{
    [ColumnsScript("AdminModule.Month")]
    [BasedOnRow(typeof(MonthRow), CheckNames = true)]
    public class MonthColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MonthId { get; set; }
        [EditLink]
        public String Name { get; set; }
    }
}