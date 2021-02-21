using System.Collections.Generic;
using LightOps.Gid.Domain.Services;
using Xunit;

namespace LightOps.Gid.Test.Tests.Services
{
    public class GidFactoryTests
    {
        [Fact]
        public void FromFragments_None()
        {
            var gidFactory = new GidFactory();
            var gid = gidFactory.FromFragments();

            Assert.Equal("gid://", gid);
        }

        [Fact]
        public void FromFragments_Single()
        {
            var gidFactory = new GidFactory();
            var gid = gidFactory.FromFragments("key");

            Assert.Equal("gid://key", gid);
        }

        [Fact]
        public void FromFragments_Multiple()
        {
            var gidFactory = new GidFactory();
            var gid = gidFactory.FromFragments("key", "value", "key2");

            Assert.Equal("gid://key/value/key2", gid);
        }

        [Fact]
        public void FromPairs_None()
        {
            var gidFactory = new GidFactory();
            var gid = gidFactory.FromPairs();

            Assert.Equal("gid://", gid);
        }

        [Fact]
        public void FromPairs_Single()
        {
            var gidFactory = new GidFactory();
            var gid = gidFactory.FromPairs(new KeyValuePair<string, string>("key", "value"));

            Assert.Equal("gid://key/value", gid);
        }

        [Fact]
        public void FromPairs_Single_NullValue()
        {
            var gidFactory = new GidFactory();
            var gid = gidFactory.FromPairs(new KeyValuePair<string, string>("key", null));

            Assert.Equal("gid://key", gid);
        }

        [Fact]
        public void FromPairs_Multiple()
        {
            var gidFactory = new GidFactory();
            var gid = gidFactory.FromPairs(
                new KeyValuePair<string, string>("key", "value"),
                new KeyValuePair<string, string>("key2", "value2"));

            Assert.Equal("gid://key/value/key2/value2", gid);
        }

        [Fact]
        public void FromPairs_Multiple_NullValue_Last()
        {
            var gidFactory = new GidFactory();
            var gid = gidFactory.FromPairs(
                new KeyValuePair<string, string>("key", "value"),
                new KeyValuePair<string, string>("key2", null));

            Assert.Equal("gid://key/value/key2", gid);
        }

        [Fact]
        public void FromPairs_Multiple_NullValue_NotLast()
        {
            var gidFactory = new GidFactory();
            var gid = gidFactory.FromPairs(
                new KeyValuePair<string, string>("key", null),
                new KeyValuePair<string, string>("key2", "value2"));

            Assert.Equal("gid://key//key2/value2", gid);
        }
    }
}