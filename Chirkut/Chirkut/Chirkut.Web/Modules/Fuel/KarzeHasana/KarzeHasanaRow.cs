using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Chirkut.Fuel
{
    [ConnectionKey("Main"), Module("Fuel"), TableName("[dbo].[KarzeHasana]")]
    [DisplayName("Karze Hasana"), InstanceName("Karze Hasana")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class KarzeHasanaRow : Row<KarzeHasanaRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Karze Hasana Id"), Identity, IdProperty]
        public Int64? KarzeHasanaId
        {
            get => fields.KarzeHasanaId[this];
            set => fields.KarzeHasanaId[this] = value;
        }

        [DisplayName("Boni Adam"), NotNull, ForeignKey("[dbo].[BoniAdam]", "BoniAdamId"), LeftJoin("g")]
        [LookupEditor(nameof(AdminModule.BoniAdamRow))]
        public Int64? BoniAdamId
        {
            get => fields.BoniAdamId[this];
            set => fields.BoniAdamId[this] = value;
        }

        [DisplayName("Amount"), Size(19), Scale(5), NotNull]
        public Decimal? Amount
        {
            get => fields.Amount[this];
            set => fields.Amount[this] = value;
        }

        [DisplayName("Initiate Date")]
        public DateTime? InitiateDate
        {
            get => fields.InitiateDate[this];
            set => fields.InitiateDate[this] = value;
        }

        [DisplayName("Return Date")]
        public DateTime? ReturnDate
        {
            get => fields.ReturnDate[this];
            set => fields.ReturnDate[this] = value;
        }

        [DisplayName("Description"), Size(250), QuickSearch, NameProperty]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Name"), Expression("g.Name")]
        public String ReceiverName
        {
            get => fields.ReceiverName[this];
            set => fields.ReceiverName[this] = value;
        }

        public KarzeHasanaRow()
            : base()
        {
        }

        public KarzeHasanaRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field KarzeHasanaId;
            public Int64Field BoniAdamId;
            public DecimalField Amount;
            public DateTimeField InitiateDate;
            public DateTimeField ReturnDate;
            public StringField Description;
            public StringField ReceiverName;
        }
    }
}
