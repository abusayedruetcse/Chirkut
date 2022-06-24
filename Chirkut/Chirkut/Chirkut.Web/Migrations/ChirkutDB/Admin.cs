using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Chirkut.Migrations.MainDB
{
    [Migration(20220624_084500)]
    public class ChirkutDB_20220624_084500_BoniAdam : Migration
    {
        public override void Up()
        {
            this.CreateTableWithId64("BoniAdam", "BoniAdamId", s => s
                .WithColumn("Name").AsString(25).NotNullable()
                .WithColumn("MobileNo").AsInt32().Nullable()
                .WithColumn("Description").AsString(150).Nullable()
                );
        }
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
