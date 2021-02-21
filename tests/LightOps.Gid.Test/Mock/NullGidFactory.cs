using System.Collections.Generic;
using LightOps.Gid.Api.Services;

namespace LightOps.Gid.Test.Mock
{
    public class NullGidFactory : IGidFactory
    {
        public string FromPairs(params KeyValuePair<string, string>[] pairs)
        {
            return default;
        }

        public string FromFragments(params string[] fragments)
        {
            return default;
        }
    }
}