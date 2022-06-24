using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Chirkut.AdminModule.BoniAdamRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Chirkut.AdminModule.BoniAdamRow;

namespace Chirkut.AdminModule
{
    public interface IBoniAdamSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BoniAdamSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBoniAdamSaveHandler
    {
        public BoniAdamSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}