using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace Chirkut.Fuel.Forms
{
    [FormScript("Fuel.KarzeHasana")]
    [BasedOnRow(typeof(KarzeHasanaRow), CheckNames = true)]
    public class KarzeHasanaForm
    {
        public Int64 BoniAdamId { get; set; }
        [HalfWidth]
        public DateTime InitiateDate { get; set; }
        [HalfWidth]
        public DateTime ReturnDate { get; set; }
        [HalfWidth]
        public Decimal Amount { get; set; }        
        [TextAreaEditor(Rows = 2)]
        public String Description { get; set; }
    }
}