using Lazar.Extensions;
using System;
using Xunit;

namespace Lazar.Tests
{
    public class StringExtTests
    {
        private enum Color
        {
            Green = 1,
            Blue = 2
        }

        [Fact]
        public void TestSplitCamelCase()
        {
            string str = "AlleMeineEntchen";
            string expected = "Alle Meine Entchen";
            string actual = str.SplitCamelCase();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRemoveLastChar()
        {
            string str = "Gurken";
            string expected = "Gurke";
            string actual = str.RemoveLastChar();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRemoveLastXChars()
        {
            string str = "Alle meine Entchen";
            string expected = "Alle";
            string actual = str.RemoveLastXChars(14);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRemoveLastCharsToMany()
        {
            string str = "Sonne";
            string expected = string.Empty;
            string actual = str.RemoveLastXChars(20);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRemoveFirstChar()
        {
            string str = "Gurken";
            string expected = "urken";
            string actual = str.RemoveFirstChar();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRemoveFirstXChars()
        {
            string str = "Alle meine Entchen";
            string expected = "Entchen";
            string actual = str.RemoveFirstXChars(11);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRemoveFirstCharsToMany()
        {
            string str = "Sonne";
            string expected = string.Empty;
            string actual = str.RemoveFirstXChars(20);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestToEnum()
        {
            string str = "Green";
            Color expected = Color.Green;
            Color actual = str.ToEnum<Color>();

            Assert.Equal(expected, actual);
        }
    }
}
