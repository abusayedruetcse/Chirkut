
namespace Chirkut.Fuel {

    @Serenity.Decorators.registerClass()
    export class KarzeHasanaGrid extends Serenity.EntityGrid<KarzeHasanaRow, any> {
        protected getColumnsKey() { return KarzeHasanaColumns.columnsKey; }
        protected getDialogType() { return KarzeHasanaDialog; }
        protected getIdProperty() { return KarzeHasanaRow.idProperty; }
        protected getInsertPermission() { return KarzeHasanaRow.insertPermission; }
        protected getLocalTextPrefix() { return KarzeHasanaRow.localTextPrefix; }
        protected getService() { return KarzeHasanaService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}