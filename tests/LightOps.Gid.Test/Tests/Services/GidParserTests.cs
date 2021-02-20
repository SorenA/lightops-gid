using LightOps.Gid.Domain.Services;
using Xunit;

namespace LightOps.Gid.Test.Tests.Services
{
    public class GidParserTests
    {
        [Fact]
        public void IsValid_Valid()
        {
            var gidParser = new GidParser();

            Assert.True(gidParser.IsValid("gid://value"));
        }

        [Fact]
        public void IsValid_Invalid()
        {
            var gidParser = new GidParser();

            Assert.False(gidParser.IsValid("id://value"));
            Assert.False(gidParser.IsValid("gid//value"));
            Assert.False(gidParser.IsValid("gid:/value"));
            Assert.False(gidParser.IsValid("guid://value"));
        }

        [Fact]
        public void GetFragments_Valid()
        {
            var gidParser = new GidParser();
            var fragments = gidParser.GetFragments("gid://key/value/1");

            Assert.NotNull(fragments);
            Assert.Equal(3, fragments.Count);
            Assert.Equal("key", fragments[0]);
            Assert.Equal("value", fragments[1]);
            Assert.Equal("1", fragments[2]);
        }

        [Fact]
        public void GetFragments_Invalid()
        {
            var gidParser = new GidParser();
            var fragments = gidParser.GetFragments("id://value");

            Assert.Null(fragments);
        }

        [Fact]
        public void GetPairs_Valid()
        {
            var gidParser = new GidParser();
            var fragments = gidParser.GetPairs("gid://key/value/1");

            Assert.NotNull(fragments);
            Assert.Equal(2, fragments.Count);
            Assert.Equal("key", fragments[0].Key);
            Assert.Equal("value", fragments[0].Value);
            Assert.Equal("1", fragments[1].Key);
            Assert.Null(fragments[1].Value);
        }

        [Fact]
        public void GetPairs_Invalid()
        {
            var gidParser = new GidParser();
            var fragments = gidParser.GetPairs("id://value");

            Assert.Null(fragments);
        }
    }
}