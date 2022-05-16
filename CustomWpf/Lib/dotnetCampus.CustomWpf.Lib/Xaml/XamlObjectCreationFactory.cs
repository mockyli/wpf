using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetCampus.WPF.Xaml
{
    public static class XamlObjectCreationFactory
    {
        public static void RegisterCreator<T>(Func<T> creator)
        {
            System.Xaml.Schema.XamlObjectCreationFactory.RegisterCreator(creator);
        }

        public static void RegisterCreator(Type type, Func<object> creator)
        {
            System.Xaml.Schema.XamlObjectCreationFactory.RegisterCreator(type, creator);
        }

        public static void RegisterTypeCreator(Func<Type, Func<object>> typeCreator)
        {
            System.Xaml.Schema.XamlObjectCreationFactory.RegisterTypeCreator(typeCreator);
        }
    }
}
