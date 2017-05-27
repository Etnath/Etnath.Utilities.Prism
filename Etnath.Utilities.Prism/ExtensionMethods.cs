using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etnath.Utilities.Prism
{
    public static class ExtensionMethods
    {
        public static IUnityContainer RegisterTypeForNavigation<T>(this IUnityContainer container, string name) where T : class, IView, IViewModel 
        {
            return container.RegisterType<object, T>(name);
        }

        public static IUnityContainer RegisterTypeForNavigation<T>(this IUnityContainer container) where T : class, IView, IViewModel
        {
            return container.RegisterType<object, T>();
        }
    }
}
