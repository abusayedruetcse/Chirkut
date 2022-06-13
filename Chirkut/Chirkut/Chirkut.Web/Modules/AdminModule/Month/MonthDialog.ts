
namespace Chirkut.AdminModule {

    @Serenity.Decorators.registerClass()
    export class MonthDialog extends Serenity.EntityDialog<MonthRow, any> {
        protected getFormKey() { return MonthForm.formKey; }
        protected getIdProperty() { return MonthRow.idProperty; }
        protected getLocalTextPrefix() { return MonthRow.localTextPrefix; }
        protected getNameProperty() { return MonthRow.nameProperty; }
        protected getService() { return MonthService.baseUrl; }
        protected getDeletePermission() { return MonthRow.deletePermission; }
        protected getInsertPermission() { return MonthRow.insertPermission; }
        protected getUpdatePermission() { return MonthRow.updatePermission; }

        protected form = new MonthForm(this.idPrefix);

    }
}