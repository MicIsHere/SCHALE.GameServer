﻿using SCHALE.Common.Database;
using SCHALE.Common.NetworkProtocol;
using SCHALE.GameServer.Services;

namespace SCHALE.GameServer.Controllers.Api.ProtocolHandlers
{
    public class Item : ProtocolHandlerBase
    {
        private ISessionKeyService sessionKeyService;
        private SCHALEContext context;

        public Item(IProtocolHandlerFactory protocolHandlerFactory, ISessionKeyService _sessionKeyService, SCHALEContext _context) : base(protocolHandlerFactory)
        {
            sessionKeyService = _sessionKeyService;
            context = _context;
        }

        [ProtocolHandler(Protocol.Item_List)]
        public ResponsePacket ListHandler(ItemListRequest req)
        {
            return new ItemListResponse()
            {
                ItemDBs = [],
                ExpiryItemDBs = [],
                ServerNotification = ServerNotificationFlag.HasUnreadMail,
            };
        }
    }
}