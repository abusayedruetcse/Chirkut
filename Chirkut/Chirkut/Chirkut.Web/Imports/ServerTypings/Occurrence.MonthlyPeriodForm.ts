namespace Chirkut.Occurrence {
    export interface MonthlyPeriodForm {
        MonthId: Serenity.LookupEditor;
        StartDate: Serenity.DateEditor;
        PeriodInterval: Serenity.StringEditor;
        EndDate: Serenity.DateEditor;
        LengthInterval: Serenity.StringEditor;
        Description: Serenity.HtmlNoteContentEditor;
    }

    export class MonthlyPeriodForm extends Serenity.PrefixedContext {
        static formKey = 'Occurrence.MonthlyPeriod';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MonthlyPeriodForm.init)  {
                MonthlyPeriodForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = s.StringEditor;
                var w3 = s.HtmlNoteContentEditor;

                Q.initFormType(MonthlyPeriodForm, [
                    'MonthId', w0,
                    'StartDate', w1,
                    'PeriodInterval', w2,
                    'EndDate', w1,
                    'LengthInterval', w2,
                    'Description', w3
                ]);
            }
        }
    }
}
