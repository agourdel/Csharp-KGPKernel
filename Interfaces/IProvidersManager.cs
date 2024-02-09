using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KGPKernel.Services._ExampleService.Interfaces;

namespace KGPKernel.Interfaces
{
    public interface IProvidersManager
    {
        public IExampleProvider ExampleProvider { get; }

    }
}
