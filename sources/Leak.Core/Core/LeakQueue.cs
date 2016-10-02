﻿using System.Collections.Concurrent;

namespace Leak.Core.Core
{
    public class LeakQueue<TContext> : LeakQueueBase<TContext>
    {
        private readonly ConcurrentQueue<LeakTask<TContext>> items;

        public LeakQueue()
        {
            items = new ConcurrentQueue<LeakTask<TContext>>();
        }

        public void Add(LeakTask<TContext> task)
        {
            items.Enqueue(task);
            onReady.Set();
        }

        public void Clear()
        {
            LeakTask<TContext> task;

            while (items.TryDequeue(out task))
            {
            }
        }

        protected override void OnProcess(TContext context)
        {
            LeakTask<TContext> task;

            while (items.TryDequeue(out task))
            {
                task.Execute(context);
            }
        }
    }
}