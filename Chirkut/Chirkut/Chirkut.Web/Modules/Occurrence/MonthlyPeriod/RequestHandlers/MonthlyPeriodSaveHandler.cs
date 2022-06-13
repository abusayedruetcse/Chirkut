using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Chirkut.Occurrence.MonthlyPeriodRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Chirkut.Occurrence.MonthlyPeriodRow;

namespace Chirkut.Occurrence
{
    public interface IMonthlyPeriodSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthlyPeriodSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMonthlyPeriodSaveHandler
    {
        public MonthlyPeriodSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}