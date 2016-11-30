﻿using Leak.Core.Common;

namespace Leak.Core.Omnibus.Components
{
    public class OmnibusState
    {
        public PeerHash Peer { get; set; }
        public int Ranking { get; set; }

        public bool IsLocalInterestedInRemote;
        public bool IsLocalChokingRemote;

        public bool IsRemoteInterestedInLocal;
        public bool IsRemoteChokingLocal;
    }
}