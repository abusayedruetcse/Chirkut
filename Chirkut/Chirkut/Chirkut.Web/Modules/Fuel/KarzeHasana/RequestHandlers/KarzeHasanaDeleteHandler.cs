using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = Chirkut.Fuel.KarzeHasanaRow;

namespace Chirkut.Fuel
{
    public interface IKarzeHasanaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class KarzeHasanaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IKarzeHasanaDeleteHandler
    {
        public KarzeHasanaDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}