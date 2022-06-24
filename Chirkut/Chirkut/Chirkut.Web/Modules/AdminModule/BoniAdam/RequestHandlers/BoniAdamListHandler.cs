using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Chirkut.AdminModule.BoniAdamRow>;
using MyRow = Chirkut.AdminModule.BoniAdamRow;

namespace Chirkut.AdminModule
{
    public interface IBoniAdamListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BoniAdamListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBoniAdamListHandler
    {
        public BoniAdamListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}