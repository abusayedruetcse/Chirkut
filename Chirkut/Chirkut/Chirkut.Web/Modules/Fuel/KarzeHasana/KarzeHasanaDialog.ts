
namespace Chirkut.Fuel {

    @Serenity.Decorators.registerClass()
    export class KarzeHasanaDialog extends Serenity.EntityDialog<KarzeHasanaRow, any> {
        protected getFormKey() { return KarzeHasanaForm.formKey; }
        protected getIdProperty() { return KarzeHasanaRow.idProperty; }
        protected getLocalTextPrefix() { return KarzeHasanaRow.localTextPrefix; }
        protected getNameProperty() { return KarzeHasanaRow.nameProperty; }
        protected getService() { return KarzeHasanaService.baseUrl; }
        protected getDeletePermission() { return KarzeHasanaRow.deletePermission; }
        protected getInsertPermission() { return KarzeHasanaRow.insertPermission; }
        protected getUpdatePermission() { return KarzeHasanaRow.updatePermission; }

        protected form = new KarzeHasanaForm(this.idPrefix);

    }
}