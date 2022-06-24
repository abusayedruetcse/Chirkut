using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Chirkut.AdminModule.BoniAdamRow>;
using MyRow = Chirkut.AdminModule.BoniAdamRow;

namespace Chirkut.AdminModule
{
    public interface IBoniAdamRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BoniAdamRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBoniAdamRetrieveHandler
    {
        public BoniAdamRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}