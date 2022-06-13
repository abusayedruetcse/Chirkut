namespace Chirkut.Occurrence {
    export interface MonthlyPeriodRow {
        MonthlyPeriodId?: number;
        MonthId?: number;
        StartDate?: string;
        EndDate?: string;
        PeriodInterval?: number;
        LengthInterval?: number;
        Description?: string;
        MonthName?: string;
    }

    export namespace MonthlyPeriodRow {
        export const idProperty = 'MonthlyPeriodId';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Occurrence.MonthlyPeriod';
        export const deletePermission = 'Occurrence:MonthlyPeriod:Modify';
        export const insertPermission = 'Occurrence:MonthlyPeriod:Modify';
        export const readPermission = 'Occurrence:MonthlyPeriod:Read';
        export const updatePermission = 'Occurrence:MonthlyPeriod:Modify';

        export declare const enum Fields {
            MonthlyPeriodId = "MonthlyPeriodId",
            MonthId = "MonthId",
            StartDate = "StartDate",
            EndDate = "EndDate",
            PeriodInterval = "PeriodInterval",
            LengthInterval = "LengthInterval",
            Description = "Description",
            MonthName = "MonthName"
        }
    }
}
