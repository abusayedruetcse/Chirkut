namespace Chirkut.AdminModule {
    export interface MonthForm {
        Name: Serenity.StringEditor;
    }

    export class MonthForm extends Serenity.PrefixedContext {
        static formKey = 'AdminModule.Month';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MonthForm.init)  {
                MonthForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(MonthForm, [
                    'Name', w0
                ]);
            }
        }
    }
}
