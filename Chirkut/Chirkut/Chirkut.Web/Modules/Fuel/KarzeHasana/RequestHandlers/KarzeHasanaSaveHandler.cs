using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<Chirkut.Fuel.KarzeHasanaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Chirkut.Fuel.KarzeHasanaRow;

namespace Chirkut.Fuel
{
    public interface IKarzeHasanaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class KarzeHasanaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IKarzeHasanaSaveHandler
    {
        public KarzeHasanaSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}