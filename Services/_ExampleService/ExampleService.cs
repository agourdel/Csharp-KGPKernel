using KGPKernel.Domains._FooDomain.Interfaces;
using KGPKernel.Services._ExampleService.Config;
using KGPKernel.Services._ExampleService.Interfaces;

namespace KGPKernel.Services._ExampleService
{
    internal class ExampleService : IFooService1
    {
        private AbstractExampleDefautConfig _Config; 
        private IExampleProvider _ExampleProvider;
        public ExampleService(AbstractExampleDefautConfig config, IExampleProvider exampleProvider)
        {
            _ExampleProvider = exampleProvider;
            _Config = config;
        }
    }
}
