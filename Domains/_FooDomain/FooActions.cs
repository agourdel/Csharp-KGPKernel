using KGPKernel.Domains._FooDomain.Config;
using KGPKernel.Domains._FooDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KGPKernel.Domains._FooDomain
{
    internal class FooActions
    {
        private IFooRepositories _fooRepositories;
        private IFooService1 _service1;
        private AbstractFooDefautConfig _config;
        public FooActions(AbstractFooDefautConfig config , IFooRepositories fooRepositories, IFooService1 service1) {
            
            _fooRepositories = fooRepositories;
            _service1 = service1;
            _config = config;
        
        }
    }
}
