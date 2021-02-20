using System;
using LightOps.DependencyInjection.Configuration;

namespace LightOps.Gid.Configuration
{
    public static class DependencyInjectionRootComponentExtensions
    {
        public static IDependencyInjectionRootComponent AddGid(this IDependencyInjectionRootComponent rootComponent, Action<IGidComponent> componentConfig = null)
        {
            var component = new GidComponent();

            // Invoke config delegate
            componentConfig?.Invoke(component);

            // Attach to root component
            rootComponent.AttachComponent(component);

            return rootComponent;
        }
    }
}