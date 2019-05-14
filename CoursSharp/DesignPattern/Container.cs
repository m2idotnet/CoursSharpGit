using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public class Container
    {
        Dictionary<Type, Type> registrations = new Dictionary<Type, Type>();

        public void Register<TInterface, TImplementation>()
        {
            registrations.Add(typeof(TInterface), typeof(TImplementation));
        }
        public TImplementation Resolver<TImplementation>()
        {
            Type creator;
            registrations.TryGetValue(typeof(TImplementation), out creator);
            return (TImplementation)Activator.CreateInstance(creator);
        }
    }
}
