using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Chirkut.AdminModule.MonthRow>;
using MyRow = Chirkut.AdminModule.MonthRow;

namespace Chirkut.AdminModule
{
    public interface IMonthRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMonthRetrieveHandler
    {
        public MonthRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}