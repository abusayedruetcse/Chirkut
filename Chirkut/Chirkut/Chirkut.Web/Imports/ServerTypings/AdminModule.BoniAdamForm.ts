namespace Chirkut.AdminModule {
    export interface BoniAdamForm {
        Name: Serenity.StringEditor;
        MobileNo: Serenity.IntegerEditor;
        Description: Serenity.TextAreaEditor;
    }

    export class BoniAdamForm extends Serenity.PrefixedContext {
        static formKey = 'AdminModule.BoniAdam';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BoniAdamForm.init)  {
                BoniAdamForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.TextAreaEditor;

                Q.initFormType(BoniAdamForm, [
                    'Name', w0,
                    'MobileNo', w1,
                    'Description', w2
                ]);
            }
        }
    }
}
