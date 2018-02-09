using Extensions;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class DictionaryExtTests
    {
        [Fact]
        public void TestStringStringDictionary()
        {
            Dictionary<string, string> emptyDict = new Dictionary<string, string>();
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                { "Key", "Value" }
            };

            Assert.True(emptyDict.IsNullOrEmpty());
            Assert.False(dict.IsNullOrEmpty());
        }

        [Fact]
        public void TestIntIntDictionary()
        {
            Dictionary<int, int> emptyDict = new Dictionary<int, int>();
            Dictionary<int, int> dict = new Dictionary<int, int>
            {
                { 1, 2 }
            };

            Assert.True(emptyDict.IsNullOrEmpty());
            Assert.False(dict.IsNullOrEmpty());
        }

        [Fact]
        public void TestIntStringDictionary()
        {
            Dictionary<int, string> emptyDict = new Dictionary<int, string>();
            Dictionary<int, string> dict = new Dictionary<int, string>
            {
                { 1, "value" }
            };

            Assert.True(emptyDict.IsNullOrEmpty());
            Assert.False(dict.IsNullOrEmpty());
        }
    }
}