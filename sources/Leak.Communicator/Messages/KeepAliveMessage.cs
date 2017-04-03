﻿using System;
using Leak.Common;

namespace Leak.Communicator.Messages
{
    public class KeepAliveMessage : NetworkOutgoingMessage
    {
        public int Length
        {
            get { return 4; }
        }

        public void ToBytes(DataBlock block)
        {
            block.With((buffer, offset, count) =>
            {
                Array.Copy(new byte[] { 0x00, 0x00, 0x00, 0x00 }, 0, buffer, offset, Length);
            });
        }

        public void Release()
        {
        }
    }
}