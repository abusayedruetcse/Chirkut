
namespace Chirkut.Occurrence {

    @Serenity.Decorators.registerClass()
    export class MonthlyPeriodGrid extends Serenity.EntityGrid<MonthlyPeriodRow, any> {
        protected getColumnsKey() { return MonthlyPeriodColumns.columnsKey; }
        protected getDialogType() { return MonthlyPeriodDialog; }
        protected getIdProperty() { return MonthlyPeriodRow.idProperty; }
        protected getInsertPermission() { return MonthlyPeriodRow.insertPermission; }
        protected getLocalTextPrefix() { return MonthlyPeriodRow.localTextPrefix; }
        protected getService() { return MonthlyPeriodService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}