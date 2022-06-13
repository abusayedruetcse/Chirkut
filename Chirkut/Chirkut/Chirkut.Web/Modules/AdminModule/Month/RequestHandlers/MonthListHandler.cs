using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Chirkut.AdminModule.MonthRow>;
using MyRow = Chirkut.AdminModule.MonthRow;

namespace Chirkut.AdminModule
{
    public interface IMonthListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMonthListHandler
    {
        public MonthListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}