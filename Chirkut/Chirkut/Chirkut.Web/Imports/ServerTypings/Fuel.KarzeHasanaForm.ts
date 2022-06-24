namespace Chirkut.Fuel {
    export interface KarzeHasanaForm {
        BoniAdamId: Serenity.LookupEditor;
        InitiateDate: Serenity.DateEditor;
        ReturnDate: Serenity.DateEditor;
        Amount: Serenity.DecimalEditor;
        Description: Serenity.TextAreaEditor;
    }

    export class KarzeHasanaForm extends Serenity.PrefixedContext {
        static formKey = 'Fuel.KarzeHasana';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!KarzeHasanaForm.init)  {
                KarzeHasanaForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.TextAreaEditor;

                Q.initFormType(KarzeHasanaForm, [
                    'BoniAdamId', w0,
                    'InitiateDate', w1,
                    'ReturnDate', w1,
                    'Amount', w2,
                    'Description', w3
                ]);
            }
        }
    }
}
