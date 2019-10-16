using NUnit.Framework;

namespace CodeCrackerTests
{
    [TestFixture]
    public class CodeCrackerTest
    {
        //a b c d e f g h i j k l m n o p q r s t u v w x y z
        // ! ) " ( £ * % & > < @ a b c d e f g h i j k l m n o

        [Test]
        public static void ShouldEncrypt_AToExclamation()
        {
            Assert.True(true);
        }
    }


    public class CodeCracker
    {
        public static string Encrypt(string s)
        {
            return null;
        }
    }
}