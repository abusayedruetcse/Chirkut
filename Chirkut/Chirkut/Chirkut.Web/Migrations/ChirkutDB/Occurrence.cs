using FluentMigrator;
using Serenity.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chirkut.Migrations.MainDB
{
    [Migration(20220611_094500)]
    public class ChirkutDB_20220611_094500_MonthlyPeriod : Migration
    {
        public override void Up()
        {
            this.CreateTableWithId64("MonthlyPeriod", "MonthlyPeriodId", s => s
                .WithColumn("MonthId").AsInt32().Nullable()
                .WithColumn("StartDate").AsDateTime().Nullable()
                .WithColumn("EndDate").AsDateTime().Nullable()
                .WithColumn("Period Interval").AsInt64().Nullable()
                .WithColumn("Length Interval").AsInt64().Nullable()
                .WithColumn("Description").AsString(700).Nullable()
                ); 
        }
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }

    [Migration(20220611_104900)]
    public class ChirkutDB_20220611_104900_Month : Migration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Month", "MonthId", s => s
                .WithColumn("Name").AsString(25).NotNullable()                
                );
        }
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
