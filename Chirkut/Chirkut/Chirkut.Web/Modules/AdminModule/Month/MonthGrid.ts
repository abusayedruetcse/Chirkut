
namespace Chirkut.AdminModule {

    @Serenity.Decorators.registerClass()
    export class MonthGrid extends Serenity.EntityGrid<MonthRow, any> {
        protected getColumnsKey() { return MonthColumns.columnsKey; }
        protected getDialogType() { return MonthDialog; }
        protected getIdProperty() { return MonthRow.idProperty; }
        protected getInsertPermission() { return MonthRow.insertPermission; }
        protected getLocalTextPrefix() { return MonthRow.localTextPrefix; }
        protected getService() { return MonthService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}