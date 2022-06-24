using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Chirkut.AdminModule.Columns
{
    [ColumnsScript("AdminModule.BoniAdam")]
    [BasedOnRow(typeof(BoniAdamRow), CheckNames = true)]
    public class BoniAdamColumns
    {
        [EditLink]
        public String Name { get; set; }
        [Width(115)]
        public Int32 MobileNo { get; set; }
        public String Description { get; set; }
    }
}