using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Chirkut.AdminModule.BoniAdamRow;

namespace Chirkut.AdminModule
{
    public interface IBoniAdamDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BoniAdamDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBoniAdamDeleteHandler
    {
        public BoniAdamDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}