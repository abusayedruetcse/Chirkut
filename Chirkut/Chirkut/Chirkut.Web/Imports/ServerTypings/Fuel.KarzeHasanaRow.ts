namespace Chirkut.Fuel {
    export interface KarzeHasanaRow {
        KarzeHasanaId?: number;
        BoniAdamId?: number;
        Amount?: number;
        InitiateDate?: string;
        ReturnDate?: string;
        Description?: string;
        ReceiverName?: string;
    }

    export namespace KarzeHasanaRow {
        export const idProperty = 'KarzeHasanaId';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Fuel.KarzeHasana';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            KarzeHasanaId = "KarzeHasanaId",
            BoniAdamId = "BoniAdamId",
            Amount = "Amount",
            InitiateDate = "InitiateDate",
            ReturnDate = "ReturnDate",
            Description = "Description",
            ReceiverName = "ReceiverName"
        }
    }
}
