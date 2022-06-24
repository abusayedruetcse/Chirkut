using FluentMigrator;
using Serenity.Extensions;
using System;

namespace Chirkut.Migrations.MainDB
{
    [Migration(20220624_085500)]
    public class ChirkutDB_20220624_085500_KarzeHasana : Migration
    {
        public override void Up()
        {
            this.CreateTableWithId64("KarzeHasana", "KarzeHasanaId", s => s
                .WithColumn("BoniAdamId").AsInt64().NotNullable()
                .WithColumn("Amount").AsDecimal().NotNullable()
                .WithColumn("InitiateDate").AsDateTime().Nullable()
                .WithColumn("ReturnDate").AsDateTime().Nullable()                
                .WithColumn("Description").AsString(250).Nullable()
                );
        }
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}
