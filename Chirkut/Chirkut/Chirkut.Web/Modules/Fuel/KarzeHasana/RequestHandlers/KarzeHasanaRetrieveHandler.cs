using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<Chirkut.Fuel.KarzeHasanaRow>;
using MyRow = Chirkut.Fuel.KarzeHasanaRow;

namespace Chirkut.Fuel
{
    public interface IKarzeHasanaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class KarzeHasanaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IKarzeHasanaRetrieveHandler
    {
        public KarzeHasanaRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}