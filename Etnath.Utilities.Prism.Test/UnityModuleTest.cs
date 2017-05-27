using System;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prism;
using Prism.Unity;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using Etnath.Utilities.Prism.Test.Infrastructure;

namespace Etnath.Utilities.Prism.Test
{
    [TestClass]
    public class UnityModuleTest
    {
        TestBootstrapper bootstrapper;

        [TestInitialize]
        public void TestInitialize()
        {
            bootstrapper = new TestBootstrapper();
            
        }

        [TestMethod]
        public void UnityModuleInitTest()
        {
            Assert.IsNotNull(bootstrapper);

            bootstrapper.Run();
            bootstrapper.Container.RegisterType<IModule,UnityModule>();
            var unityModule = bootstrapper.Container.Resolve<IModule>();

            Assert.IsNotNull(unityModule);
        }
    }

    
}
