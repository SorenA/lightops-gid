using System;
using System.Collections.Generic;
using System.Linq;
using LightOps.Gid.Api.Services;

namespace LightOps.Gid.Domain.Services
{
    public class GidParser : IGidParser
    {
        public bool IsValid(string gid)
        {
            return gid.StartsWith("gid://");
        }

        public IList<KeyValuePair<string, string>> GetPairs(string gid)
        {
            var fragments = GetFragments(gid);

            return fragments?
                .Select((item, idx) => new { item, idx })
                .GroupBy(x => x.idx / 2)
                .Select(g => new KeyValuePair<string, string>(g.FirstOrDefault()?.item, g.Skip(1).FirstOrDefault()?.item))
                .ToList();
        }

        public IList<string> GetFragments(string gid)
        {
            if (!IsValid(gid))
            {
                return null;
            }

            return gid
                .Substring(6) // Trim gid://
                .Split(new[] {"/"}, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}