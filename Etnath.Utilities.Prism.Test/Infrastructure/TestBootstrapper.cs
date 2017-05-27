using Prism.Modularity;
using Prism.Unity;
using System.Windows;
using Microsoft.Practices.Unity;

namespace Etnath.Utilities.Prism.Test.Infrastructure
{
    public class TestBootstrapper : UnityBootstrapper
    {

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog.AddModule(new ModuleInfo(
                typeof(UnityModule).Name,
                typeof(UnityModule).AssemblyQualifiedName));
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
        }
    }
}
