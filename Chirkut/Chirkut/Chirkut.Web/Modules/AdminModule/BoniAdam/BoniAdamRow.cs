using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Chirkut.AdminModule
{
    [ConnectionKey("Main"), Module("AdminModule"), TableName("[dbo].[BoniAdam]")]
    [DisplayName("Boni Adam"), InstanceName("Boni Adam")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript(nameof(AdminModule.BoniAdamRow))]
    public sealed class BoniAdamRow : Row<BoniAdamRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Boni Adam Id"), Identity, IdProperty]
        public Int64? BoniAdamId
        {
            get => fields.BoniAdamId[this];
            set => fields.BoniAdamId[this] = value;
        }

        [DisplayName("Name"), Size(25), NotNull, QuickSearch, NameProperty]
        public String Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }

        [DisplayName("Mobile No")]
        public Int32? MobileNo
        {
            get => fields.MobileNo[this];
            set => fields.MobileNo[this] = value;
        }

        [DisplayName("Description"), Size(150)]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        public BoniAdamRow()
            : base()
        {
        }

        public BoniAdamRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field BoniAdamId;
            public StringField Name;
            public Int32Field MobileNo;
            public StringField Description;
        }
    }
}
