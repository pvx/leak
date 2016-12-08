﻿using Leak.Common;
using Leak.Networking;
using Leak.Tasks;

namespace Leak.Core.Connector
{
    public class PeerConnector
    {
        private readonly PeerConnectorContext context;

        public PeerConnector(NetworkPool pool, PeerConnectorHooks hooks, PeerConnectorConfiguration configuration)
        {
            context = new PeerConnectorContext(pool, hooks, configuration);
        }

        public void Start(LeakPipeline pipeline)
        {
            pipeline.Register(context.Queue);
        }

        public void ConnectTo(FileHash hash, PeerAddress peer)
        {
            context.Queue.Add(new PeerConnectorTaskConnect(hash, peer));
        }
    }
}