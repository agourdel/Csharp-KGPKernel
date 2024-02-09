using KGPKernel.Domains._FooDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGPKernel.Interfaces
{
    public interface IRepositoriesManager
    {
        public IFooRepositories FooRepositories { get; }

    }
}
