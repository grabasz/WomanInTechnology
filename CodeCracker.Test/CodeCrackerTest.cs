using System;
using NUnit.Framework;

namespace CodeCrackerTests
{
    [TestFixture]
    public class CodeCrackerTest
    {
        [SetUp]
        public void SetUp()
        {
            _codeCracker = new CodeCracker();
        }

        private static CodeCracker _codeCracker;

        [Test]
        public static void ShouldEncrypt_AToExclamation()
        {
            var encrypted = _codeCracker.Encrypt("a");
            Assert.AreEqual("!", encrypted);
        }

        [Test]
        public static void ShouldEncrypt_BToParenthese()
        {
            var encrypted = _codeCracker.Encrypt("b");
            Assert.AreEqual(")", encrypted);
        }

        [Test]
        public static void ShouldEncrypt_CToDoubleQuote()
        {
            var encrypted = _codeCracker.Encrypt("c");
            Assert.AreEqual("\"", encrypted);
        }

        [Test]
        public static void ShouldEncrypt_DoubleQuoteToC()
        {
            var encrypted = _codeCracker.Decrypt("\"");
            Assert.AreEqual("c", encrypted);
        }

        [Test]
        public static void ShouldEncrypt_lmnoTowxyz()
        {
            var encrypted = _codeCracker.Decrypt("lmno");
            Assert.AreEqual("wxyz", encrypted);
        }

        [Test]
        public static void ShouldDecrypt_wxyzTolmno()
        {
            var encrypted = _codeCracker.Encrypt("wxyz");
            Assert.AreEqual("lmno", encrypted);
        }

        [Test]
        public static void ShouldEncrypt_nullToException()
        {
            Assert.Throws<ArgumentNullException>(() => _codeCracker.Decrypt(null));
        }
    }
}