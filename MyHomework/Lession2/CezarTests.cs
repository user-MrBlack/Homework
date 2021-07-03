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
        [TestCase("aa aa", 1, "bb bb")]
        [TestCase(" ", 1, " ")]
        [TestCase("Abc", 1500, "Stu")]
        [TestCase("abc abc", 26000, "abc abc")]
        public void EncryptTests(string text, int key, string result)
        {
            Assert.AreEqual(Cezar2.Encrypt(text, key), result);
        }
        
        [TestCase("a", 1, "z")]
        [TestCase("z", 2, "x")]
        [TestCase("aaB", 2, "yyZ")]
        [TestCase("a a", 1, "z z")]
        [TestCase("abC Cba", 1, "zaB Baz")]
        [TestCase("abc", 26000, "abc")]
        [TestCase("That which we call a rose by any other name would smell as sweet", 1000000, "Ftmf ituot iq omxx m daeq nk mzk aftqd zmyq iagxp eyqxx me eiqqf")]
        [TestCase("Seryoga is the best", 1990, "Eqdkasm ue ftq nqef")]
        public void DecryptTests(string text, int key, string result)
        {
            Assert.AreEqual(Cezar2.Decrypt(text, key), result);
        }
    }
}
