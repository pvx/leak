﻿using Leak.Common;
using Leak.Networking;

namespace Leak.Negotiator
{
    public class HandshakeConnectionToEncryptor : NetworkOutgoingEncryptor
    {
        private readonly HandshakeKey key;

        public HandshakeConnectionToEncryptor(HandshakeKey key)
        {
            this.key = key;
        }

        public void Encrypt(DataBlock block)
        {
            key.Encrypt(block);
        }

        public void Encrypt(byte[] data, int offset, int count)
        {
            key.Encrypt(data, offset, count);
        }
    }
}