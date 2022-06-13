using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Chirkut.Occurrence.MonthlyPeriodRow;

namespace Chirkut.Occurrence
{
    public interface IMonthlyPeriodDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthlyPeriodDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMonthlyPeriodDeleteHandler
    {
        public MonthlyPeriodDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}