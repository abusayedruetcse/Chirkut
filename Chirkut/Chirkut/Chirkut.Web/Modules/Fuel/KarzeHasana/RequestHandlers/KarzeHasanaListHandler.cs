using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<Chirkut.Fuel.KarzeHasanaRow>;
using MyRow = Chirkut.Fuel.KarzeHasanaRow;

namespace Chirkut.Fuel
{
    public interface IKarzeHasanaListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class KarzeHasanaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IKarzeHasanaListHandler
    {
        public KarzeHasanaListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}