using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Chirkut.Occurrence.MonthlyPeriodRow>;
using MyRow = Chirkut.Occurrence.MonthlyPeriodRow;

namespace Chirkut.Occurrence
{
    public interface IMonthlyPeriodListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthlyPeriodListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMonthlyPeriodListHandler
    {
        public MonthlyPeriodListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}