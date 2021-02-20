using LightOps.Gid.Api.Services;

namespace LightOps.Gid.Configuration
{
    /// <summary>
    /// Gid dependency injection component
    /// </summary>
    public interface IGidComponent
    {
        #region Services
        /// <summary>
        /// Overrides gid parser with implementation of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of the implementation</typeparam>
        /// <returns>Returns component for chaining</returns>
        IGidComponent OverrideGidParser<T>() where T : IGidParser;
        #endregion Services
    }
}