
namespace Chirkut.AdminModule {

    @Serenity.Decorators.registerClass()
    export class BoniAdamGrid extends Serenity.EntityGrid<BoniAdamRow, any> {
        protected getColumnsKey() { return BoniAdamColumns.columnsKey; }
        protected getDialogType() { return BoniAdamDialog; }
        protected getIdProperty() { return BoniAdamRow.idProperty; }
        protected getInsertPermission() { return BoniAdamRow.insertPermission; }
        protected getLocalTextPrefix() { return BoniAdamRow.localTextPrefix; }
        protected getService() { return BoniAdamService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}