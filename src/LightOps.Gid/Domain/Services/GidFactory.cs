using System;
using System.Collections.Generic;
using System.Linq;
using LightOps.Gid.Api.Services;

namespace LightOps.Gid.Domain.Services
{
    public class GidFactory : IGidFactory
    {
        public string FromPairs(params KeyValuePair<string, string>[] pairs)
        {
            if (!pairs.Any())
            {
                // No pairs, return empty gid
                return FromFragments();
            }

            // Convert to pairs and trim trailing slash
            return FromFragments(pairs
                    .Select(x => $"{x.Key}/{x.Value}")
                    .ToArray())
                .TrimEnd('/');
        }

        public string FromFragments(params string[] fragments)
        {
            return $"gid://{string.Join("/", fragments)}";
        }
    }
}