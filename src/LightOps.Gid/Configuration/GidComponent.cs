using System.Collections.Generic;
using System.Linq;
using LightOps.DependencyInjection.Api.Configuration;
using LightOps.DependencyInjection.Domain.Configuration;
using LightOps.Gid.Api.Services;
using LightOps.Gid.Domain.Services;

namespace LightOps.Gid.Configuration
{
    public class GidComponent : IDependencyInjectionComponent, IGidComponent
    {
        public string Name => "lightops.gid";

        public IReadOnlyList<ServiceRegistration> GetServiceRegistrations()
        {
            return new List<ServiceRegistration>()
                .Union(_services.Values)
                .ToList();
        }

        #region Services
        internal enum Services
        {
            GidParser,
        }

        private readonly Dictionary<Services, ServiceRegistration> _services = new Dictionary<Services, ServiceRegistration>
        {
            [Services.GidParser] = ServiceRegistration.Transient<IGidParser, GidParser>(),
        };

        public IGidComponent OverrideGidParser<T>()
            where T : IGidParser
        {
            _services[Services.GidParser].ImplementationType = typeof(T);
            return this;
        }
        #endregion Services
    }
}