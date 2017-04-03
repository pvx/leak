﻿using System.Collections.Generic;
using Leak.Common;

namespace Leak.Data.Share
{
    public class DataShareCollection
    {
        private readonly Dictionary<BlockIndex, List<DataShareEntry>> byBlocks;

        public DataShareCollection()
        {
            byBlocks = new Dictionary<BlockIndex, List<DataShareEntry>>();
        }

        public void Register(PeerHash peer, BlockIndex block)
        {
            List<DataShareEntry> entries;

            if (byBlocks.TryGetValue(block, out entries) == false)
            {
                entries = new List<DataShareEntry>();
                byBlocks.Add(block, entries);
            }

            entries.Add(new DataShareEntry
            {
                Peer = peer,
                Block = block
            });
        }

        public IList<DataShareEntry> RemoveAll(BlockIndex block)
        {
            List<DataShareEntry> entries;

            if (byBlocks.TryGetValue(block, out entries) == false)
            {
                entries = new List<DataShareEntry>();
            }

            byBlocks.Remove(block);
            return entries;
        }
    }
}