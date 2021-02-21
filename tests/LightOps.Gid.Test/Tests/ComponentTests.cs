using LightOps.DependencyInjection.Api.Providers;
using LightOps.DependencyInjection.Configuration;
using LightOps.Gid.Api.Services;
using LightOps.Gid.Configuration;
using LightOps.Gid.Test.Mock;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace LightOps.Gid.Test.Tests
{
    public class ComponentTests
    {
        [Fact]
        public void TestComponent_IsAttached()
        {
            var services = new ServiceCollection();

            // Add component
            services.AddLightOpsDependencyInjection(root =>
            {
                root.AddGid();
            });

            var serviceProvider = services.BuildServiceProvider();

            // Get component state provider
            var dependencyInjectionComponentStateProvider = serviceProvider.GetService<IDependencyInjectionComponentStateProvider>();

            Assert.Contains("lightops.gid",
                dependencyInjectionComponentStateProvider.AttachedComponentNames);
        }

        [Fact]
        public void TestComponent_Configuration_Invoked()
        {
            var services = new ServiceCollection();

            // Add component
            var invoked = false;
            services.AddLightOpsDependencyInjection(root =>
            {
                root.AddGid(component =>
                {
                    invoked = true;
                });
            });

            var serviceProvider = services.BuildServiceProvider();

            Assert.True(invoked);
        }

        [Fact]
        public void TestComponent_Override_GidParser()
        {
            var services = new ServiceCollection();

            // Add component
            services.AddLightOpsDependencyInjection(root =>
            {
                root.AddGid(component =>
                {
                    component.OverrideGidParser<NullGidParser>();
                });
            });

            var serviceProvider = services.BuildServiceProvider();

            Assert.IsType<NullGidParser>(serviceProvider.GetService<IGidParser>());
        }

        [Fact]
        public void TestComponent_Override_GidFactory()
        {
            var services = new ServiceCollection();

            // Add component
            services.AddLightOpsDependencyInjection(root =>
            {
                root.AddGid(component =>
                {
                    component.OverrideGidFactory<NullGidFactory>();
                });
            });

            var serviceProvider = services.BuildServiceProvider();

            Assert.IsType<NullGidFactory>(serviceProvider.GetService<IGidFactory>());
        }
    }
}