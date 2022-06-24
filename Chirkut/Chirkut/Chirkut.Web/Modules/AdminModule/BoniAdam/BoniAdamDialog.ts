
namespace Chirkut.AdminModule {

    @Serenity.Decorators.registerClass()
    export class BoniAdamDialog extends Serenity.EntityDialog<BoniAdamRow, any> {
        protected getFormKey() { return BoniAdamForm.formKey; }
        protected getIdProperty() { return BoniAdamRow.idProperty; }
        protected getLocalTextPrefix() { return BoniAdamRow.localTextPrefix; }
        protected getNameProperty() { return BoniAdamRow.nameProperty; }
        protected getService() { return BoniAdamService.baseUrl; }
        protected getDeletePermission() { return BoniAdamRow.deletePermission; }
        protected getInsertPermission() { return BoniAdamRow.insertPermission; }
        protected getUpdatePermission() { return BoniAdamRow.updatePermission; }

        protected form = new BoniAdamForm(this.idPrefix);

    }
}