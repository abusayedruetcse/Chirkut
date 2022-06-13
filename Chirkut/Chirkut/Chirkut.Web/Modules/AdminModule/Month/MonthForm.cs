using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Chirkut.AdminModule.Forms
{
    [FormScript("AdminModule.Month")]
    [BasedOnRow(typeof(MonthRow), CheckNames = true)]
    public class MonthForm
    {
        public String Name { get; set; }
    }
}