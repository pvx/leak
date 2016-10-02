﻿using Leak.Commands;
using Pargos.Core;
using Pargos.Serialization;
using System;

namespace Leak
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ArgumentCollection arguments = ArgumentFactory.Parse(args);
            Options options = arguments.Deserialize<Options>();

            if (options.Download != null)
            {
                new DownloadCommand(options.Download).Execute();
            }

            Environment.Exit(0);
        }
    }
}