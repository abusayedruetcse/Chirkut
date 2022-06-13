using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Chirkut.Occurrence.MonthlyPeriodRow>;
using MyRow = Chirkut.Occurrence.MonthlyPeriodRow;

namespace Chirkut.Occurrence
{
    public interface IMonthlyPeriodRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthlyPeriodRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMonthlyPeriodRetrieveHandler
    {
        public MonthlyPeriodRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}