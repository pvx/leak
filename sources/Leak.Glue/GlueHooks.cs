﻿using Leak.Events;
using System;

namespace Leak.Glue
{
    public class GlueHooks
    {
        public Action<PeerConnected> OnPeerConnected;
        public Action<PeerDisconnected> OnPeerDisconnected;

        public Action<PeerBitfieldChanged> OnPeerBitfieldChanged;
        public Action<PeerStatusChanged> OnPeerStatusChanged;

        public Action<BlockReceived> OnBlockReceived;
        public Action<BlockRequested> OnBlockRequested;

        public Action<ExtensionListReceived> OnExtensionListReceived;
        public Action<ExtensionListSent> OnExtensionListSent;

        public Action<ExtensionDataReceived> OnExtensionDataReceived;
        public Action<ExtensionDataSent> OnExtensionDataSent;
    }
}