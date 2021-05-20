using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Lession2
{
    [TestFixture]
    public class CezarTests
    {
        [TestCase("a", 1, "b")]
        [TestCase("b", 1, "c")]
        [TestCase("aaaaa", 1, "bbbbb")]
        [TestCase("zzzza", 2, "bbbbc")]
        [TestCase("a a", 1, "b b")]
        [TestCase("aAa", 1, "bBb")]
        [TestCase("aZz", 1, "bAa")]
        [TestCase("aA A", 1, "bB B")]
        [TestCase("a ZZz", 1, "b AAa")]
        public void EncryptTests(string text, int key, string result)
        {
            Assert.AreEqual(Cezar2.Encrypt(text, key), result);
        }
    }
}
