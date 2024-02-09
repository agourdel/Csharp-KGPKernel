using KGPKernel.Domains._FooDomain.Config;
using KGPKernel.Services._ExampleService.Config;

namespace KGPKernel.Interfaces
{
    public interface IConfigsManager
    {
        public AbstractFooDefautConfig FooConfig { get; }
        public AbstractExampleDefautConfig ExampleConfig { get; }
    
    }
}
