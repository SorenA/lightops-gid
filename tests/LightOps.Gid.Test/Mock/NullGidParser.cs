using System.Collections.Generic;
using LightOps.Gid.Api.Services;

namespace LightOps.Gid.Test.Mock
{
    public class NullGidParser : IGidParser

    {
        public bool IsValid(string gid)
        {
            return true;
        }

        public IList<KeyValuePair<string, string>> GetPairs(string gid)
        {
            return default;
        }

        public IList<string> GetFragments(string gid)
        {
            return default;
        }
    }
}