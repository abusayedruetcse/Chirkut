namespace Chirkut.AdminModule {
    export interface BoniAdamRow {
        BoniAdamId?: number;
        Name?: string;
        MobileNo?: number;
        Description?: string;
    }

    export namespace BoniAdamRow {
        export const idProperty = 'BoniAdamId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'AdminModule.BoniAdam';
        export const lookupKey = 'BoniAdamRow';

        export function getLookup(): Q.Lookup<BoniAdamRow> {
            return Q.getLookup<BoniAdamRow>('BoniAdamRow');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            BoniAdamId = "BoniAdamId",
            Name = "Name",
            MobileNo = "MobileNo",
            Description = "Description"
        }
    }
}
