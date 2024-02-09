using System;
using System.Collections.Generic;
using System.Linq;
using KGPKernel.Domains._FooDomain;
using KGPKernel.Services;
using KGPKernel.Interfaces;

namespace KGPKernel.Domains
{
    internal class DomainsManager
    {
        public FooActions FooActions { get; set; }
        public DomainsManager(IConfigsManager configManager, IRepositoriesManager repositoriesManager, ServicesManager servicesManager) {

            FooActions = new FooActions(configManager.FooConfig, repositoriesManager.FooRepositories, servicesManager.ExampleService) ;
        
        }

    }
}
