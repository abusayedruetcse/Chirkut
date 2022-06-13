namespace Chirkut.Occurrence {
    export namespace MonthlyPeriodService {
        export const baseUrl = 'Occurrence/MonthlyPeriod';

        export declare function Create(request: Serenity.SaveRequest<MonthlyPeriodRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MonthlyPeriodRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MonthlyPeriodRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MonthlyPeriodRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Occurrence/MonthlyPeriod/Create",
            Update = "Occurrence/MonthlyPeriod/Update",
            Delete = "Occurrence/MonthlyPeriod/Delete",
            Retrieve = "Occurrence/MonthlyPeriod/Retrieve",
            List = "Occurrence/MonthlyPeriod/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>MonthlyPeriodService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
