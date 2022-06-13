namespace Chirkut.AdminModule {
    export interface MonthRow {
        MonthId?: number;
        Name?: string;
    }

    export namespace MonthRow {
        export const idProperty = 'MonthId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'AdminModule.Month';
        export const lookupKey = 'MonthRow';

        export function getLookup(): Q.Lookup<MonthRow> {
            return Q.getLookup<MonthRow>('MonthRow');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MonthId = "MonthId",
            Name = "Name"
        }
    }
}
