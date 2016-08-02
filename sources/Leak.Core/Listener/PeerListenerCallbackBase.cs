﻿using Leak.Core.Network;
using System;

namespace Leak.Core.Listener
{
    public abstract class PeerListenerCallbackBase : PeerListenerCallback
    {
        public virtual void OnStarted()
        {
        }

        public virtual void OnStopped()
        {
        }

        public virtual void OnConnected(NetworkConnection connection)
        {
        }

        public virtual void OnRejected(NetworkConnection connection)
        {
        }

        public virtual void OnHandshake(NetworkConnection connection, PeerListenerHandshake handshake)
        {
        }

        public virtual void OnException(NetworkConnection connection, Exception ex)
        {
        }

        public virtual void OnDisconnected(NetworkConnection connection)
        {
        }
    }
}