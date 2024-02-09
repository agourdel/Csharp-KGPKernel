using KGPKernel.Interfaces;
using KGPKernel.Domains;
using KGPKernel.Services;

using KGPKernel.Roles._WaldoRole;

namespace KGPKernel
{
    public class Kernel
    {
        public struct RolesStruct
        {
            public WaldoRoleUseCases Waldo;
        }
      
        private  IRepositoriesManager RepositoryManager { get; }
        private IProvidersManager ProvidersManager { get; set; }
        private IConfigsManager ConfigsManager {  get; set; }
        private  ServicesManager ServicesManager { get; set; }
        private DomainsManager DomainsManager { get; set; }

        public RolesStruct Roles {  get; set; }


        public Kernel(IConfigsManager config, IRepositoriesManager repositoryManager, IProvidersManager providersManager)
        {
            RepositoryManager = repositoryManager;
            ProvidersManager = providersManager;
            ConfigsManager = config;

            InitManagers();
            InitRoles();
           
        }


        private void InitManagers()
        {
            ServicesManager = new ServicesManager(ConfigsManager, ProvidersManager);
            DomainsManager = new DomainsManager(ConfigsManager, RepositoryManager, ServicesManager);
        }

        private void InitRoles()
        {

            if(ServicesManager == null || DomainsManager == null)
            {
                throw new Exception("ServicesManager and DomainsManager can't be null");
            }

            Roles = new RolesStruct
            {
                Waldo = new WaldoRoleUseCases(ConfigsManager, ServicesManager, DomainsManager)
            };

        }

        

    }
}
