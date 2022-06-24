using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Chirkut.Fuel.Columns
{
    [ColumnsScript("Fuel.KarzeHasana")]
    [BasedOnRow(typeof(KarzeHasanaRow), CheckNames = true)]
    public class KarzeHasanaColumns
    {
        [EditLink]
        public String ReceiverName { get; set; }
        public Decimal Amount { get; set; }
        public DateTime InitiateDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public String Description { get; set; }
    }
}