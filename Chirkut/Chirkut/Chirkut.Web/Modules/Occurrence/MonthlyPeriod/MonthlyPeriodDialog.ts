
namespace Chirkut.Occurrence {

    @Serenity.Decorators.registerClass()
    export class MonthlyPeriodDialog extends Serenity.EntityDialog<MonthlyPeriodRow, any> {
        protected getFormKey() { return MonthlyPeriodForm.formKey; }
        protected getIdProperty() { return MonthlyPeriodRow.idProperty; }
        protected getLocalTextPrefix() { return MonthlyPeriodRow.localTextPrefix; }
        protected getNameProperty() { return MonthlyPeriodRow.nameProperty; }
        protected getService() { return MonthlyPeriodService.baseUrl; }
        protected getDeletePermission() { return MonthlyPeriodRow.deletePermission; }
        protected getInsertPermission() { return MonthlyPeriodRow.insertPermission; }
        protected getUpdatePermission() { return MonthlyPeriodRow.updatePermission; }

        protected form = new MonthlyPeriodForm(this.idPrefix);

    }
}