﻿using Leak.Common;
using System.Collections.Generic;

namespace Leak.Leakage
{
    public class LeakRegistrant
    {
        public LeakRegistrant()
        {
            Trackers = new List<string>();
            Peers = new List<PeerAddress>();
        }

        public FileHash Hash;

        public string Destination;

        public ICollection<string> Trackers;

        public ICollection<PeerAddress> Peers;
    }
}