﻿using Leak.Common;
using System;

namespace Leak.Omnibus.Components
{
    public class OmnibusReservation
    {
        public PeerHash Peer { get; set; }

        public DateTime Expires { get; set; }

        public BlockIndex Request { get; set; }
    }
}