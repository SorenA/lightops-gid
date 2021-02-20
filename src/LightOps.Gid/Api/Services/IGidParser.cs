using System.Collections.Generic;

namespace LightOps.Gid.Api.Services
{
    /// <summary>
    /// Parser for parsing a gid
    /// </summary>
    public interface IGidParser
    {
        /// <summary>
        /// Validates a gid
        /// </summary>
        /// <param name="gid">The gid to validate</param>
        /// <returns>A value indicating whether or not the gid is valid</returns>
        bool IsValid(string gid);

        /// <summary>
        /// Parse a gid into key-value pairs
        /// </summary>
        /// <param name="gid">The gid to parse</param>
        /// <returns>The key-value pairs of the gid</returns>
        IList<KeyValuePair<string, string>> GetPairs(string gid);

        /// <summary>
        /// Parse a gid into a list of fragments
        /// </summary>
        /// <param name="gid">The gid to parse</param>
        /// <returns>The list of fragments of the gid</returns>
        IList<string> GetFragments(string gid);
    }
}