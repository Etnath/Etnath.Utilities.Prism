using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace Etnath.Utilities.Prism
{
    public class UnityModule : IModule
    {
        IRegionManager _regionManager;
        IUnityContainer _container;

        public UnityModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            
        }
    }
}
