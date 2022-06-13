using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace Chirkut.Occurrence
{
    [ConnectionKey("Main"), Module("Occurrence"), TableName("[dbo].[MonthlyPeriod]")]
    [DisplayName("Monthly Period"), InstanceName("Monthly Period")]
    [ReadPermission("Occurrence:MonthlyPeriod:Read")]
    [ModifyPermission("Occurrence:MonthlyPeriod:Modify")]
    public sealed class MonthlyPeriodRow : Row<MonthlyPeriodRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Monthly Period Id"), Identity, IdProperty]
        public Int64? MonthlyPeriodId
        {
            get => fields.MonthlyPeriodId[this];
            set => fields.MonthlyPeriodId[this] = value;
        }

        [DisplayName("Month Id"), ForeignKey("[dbo].[Month]", "MonthId"), LeftJoin("g")]
        [LookupEditor(nameof(AdminModule.MonthRow))]
        public Int32? MonthId
        {
            get => fields.MonthId[this];
            set => fields.MonthId[this] = value;
        }

        [DisplayName("Start Date")]
        public DateTime? StartDate
        {
            get => fields.StartDate[this];
            set => fields.StartDate[this] = value;
        }

        [DisplayName("End Date")]
        public DateTime? EndDate
        {
            get => fields.EndDate[this];
            set => fields.EndDate[this] = value;
        }

        [DisplayName("Period Distance"), Column("Period Interval")]
        public Int64? PeriodInterval
        {
            get => fields.PeriodInterval[this];
            set => fields.PeriodInterval[this] = value;
        }

        [DisplayName("Period Length"), Column("Length Interval")]
        public Int64? LengthInterval
        {
            get => fields.LengthInterval[this];
            set => fields.LengthInterval[this] = value;
        }

        [DisplayName("Description"), Size(700), QuickSearch, NameProperty]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Month"), Expression("g.Name")]
        public String MonthName
        {
            get => fields.MonthName[this];
            set => fields.MonthName[this] = value;
        }

        public MonthlyPeriodRow()
            : base()
        {
        }

        public MonthlyPeriodRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field MonthlyPeriodId;
            public Int32Field MonthId;
            public DateTimeField StartDate;
            public DateTimeField EndDate;
            public Int64Field PeriodInterval;
            public Int64Field LengthInterval;
            public StringField Description;
            public StringField MonthName;
        }
    }
}
