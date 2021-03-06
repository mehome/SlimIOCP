﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SlimIOCP
{
    public interface IMessageBuffer<TIncomingMessage, TOutgoingMessage, TConnection>
        where TIncomingMessage : IncomingMessage<TOutgoingMessage, TConnection>
        where TOutgoingMessage : OutgoingMessage
        where TConnection : Connection<TOutgoingMessage>
    {
        TIncomingMessage CurrentMessage { get; set; }
    }
}
