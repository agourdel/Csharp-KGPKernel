using KGPKernel.Interfaces;
using KGPKernel.Services._ExampleService;

namespace KGPKernel.Services
{
    internal class ServicesManager
    {
        private IProvidersManager _providersManager;
        private IConfigsManager _configsManager;
        public ExampleService ExampleService { get; private set; }
        public ServicesManager(IConfigsManager configsManager,IProvidersManager providersManager)
        {

            _configsManager = configsManager;
            _providersManager = providersManager;


            ExampleService = new ExampleService(_configsManager.ExampleConfig, _providersManager.ExampleProvider);

        }


    }
}
