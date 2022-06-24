using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Chirkut.AdminModule.Forms
{
    [FormScript("AdminModule.BoniAdam")]
    [BasedOnRow(typeof(BoniAdamRow), CheckNames = true)]
    public class BoniAdamForm
    {
        public String Name { get; set; }
        public Int32 MobileNo { get; set; }
        [TextAreaEditor(Rows = 3)]
        public String Description { get; set; }
    }
}