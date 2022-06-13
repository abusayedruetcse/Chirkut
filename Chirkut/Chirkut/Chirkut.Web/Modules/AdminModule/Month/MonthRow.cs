using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Chirkut.AdminModule
{
    [ConnectionKey("Main"), Module("AdminModule"), TableName("[dbo].[Month]")]
    [DisplayName("Month"), InstanceName("Month")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript(nameof(AdminModule.MonthRow))]
    public sealed class MonthRow : Row<MonthRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Month Id"), Identity, IdProperty, SortOrder(1)]
        public Int32? MonthId
        {
            get => fields.MonthId[this];
            set => fields.MonthId[this] = value;
        }

        [DisplayName("Name"), Size(25), NotNull, QuickSearch, NameProperty]
        public String Name
        {
            get => fields.Name[this];
            set => fields.Name[this] = value;
        }
       
        public MonthRow()
            : base()
        {
        }

        public MonthRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MonthId;
            public StringField Name;
        }
    }
}
