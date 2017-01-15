﻿using Leak.Common;
using Leak.Files;
using Leak.Tasks;

namespace Leak.Repository
{
    public class RepositoryBuilder
    {
        private readonly RepositoryParameters parameters;
        private readonly RepositoryDependencies dependencies;
        private readonly RepositoryConfiguration configuration;

        public RepositoryBuilder()
        {
            parameters = new RepositoryParameters();
            dependencies = new RepositoryDependencies();
            configuration = new RepositoryConfiguration();
        }

        public RepositoryBuilder WithHash(FileHash hash)
        {
            parameters.Hash = hash;
            return this;
        }

        public RepositoryBuilder WithDestination(string destination)
        {
            parameters.Destination = destination;
            return this;
        }

        public RepositoryBuilder WithFiles(FileFactory files)
        {
            dependencies.Files = files;
            return this;
        }

        public RepositoryBuilder WithPipeline(LeakPipeline pipeline)
        {
            dependencies.Pipeline = pipeline;
            return this;
        }

        public RepositoryService Build()
        {
            return Build(new RepositoryHooks());
        }

        public RepositoryService Build(RepositoryHooks hooks)
        {
            return new RepositoryService(parameters, dependencies, hooks, configuration);
        }
    }
}