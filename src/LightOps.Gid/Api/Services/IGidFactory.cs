using System.Collections.Generic;

namespace LightOps.Gid.Api.Services
{
    /// <summary>
    /// Factory for creating a gid
    /// </summary>
    public interface IGidFactory
    {
        /// <summary>
        /// Create a gid from key-value pairs
        /// </summary>
        /// <param name="pairs">The key-value pairs to create the gid from</param>
        /// <returns>the created gid</returns>
        string FromPairs(params KeyValuePair<string, string>[] pairs);

        /// <summary>
        /// Create a gid from a list of fragments
        /// </summary>
        /// <param name="fragments">The fragments to create the gid from</param>
        /// <returns>the created gid</returns>
        string FromFragments(params string[] fragments);
    }
}