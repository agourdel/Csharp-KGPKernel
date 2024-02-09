using KGPKernel.Services;
using KGPKernel.Domains;
using KGPKernel.Interfaces;

namespace KGPKernel.Roles._WaldoRole
{
    public class WaldoRoleUseCases
    {

        private IConfigsManager _configsManager;
        private  ServicesManager _servicesManager;
        private  DomainsManager _domainsManager;
         

        internal WaldoRoleUseCases(IConfigsManager configsManager,ServicesManager servicesManager, DomainsManager domainsManager)
        {
            _configsManager = configsManager;
            _servicesManager = servicesManager;
            _domainsManager = domainsManager;

        }

    }
}
