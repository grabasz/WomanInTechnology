using System.Collections.Generic;
using System.Linq;

namespace CodeCrackerTests
{
    public class CodeCracker
    {
        private const string EncryptedAlphabet =  "! ) \" ( £ * % & > < @ a b c d e f g h i j k l m n o";
        private const string UnecryptedAlphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
        private List<string> UnencryptedList { get; }
        private List<string> EncryptedList { get; }

        public CodeCracker()
        {
            UnencryptedList = SplitAlphabet(UnecryptedAlphabet);
            EncryptedList = SplitAlphabet(EncryptedAlphabet);
        }

        public string Encrypt(string s)
        {
            return TranslateForEachCharacters(UnencryptedList, EncryptedList, s);
        }

        public string Decrypt(string s)
        {
            return TranslateForEachCharacters(EncryptedList, UnencryptedList, s);
        }

        private string TranslateForEachCharacters(List<string> @from, List<string> to, string s)
        {
            var result = s.Select(x => Translate(@from, to, x.ToString()));
            return string.Join("", result);
        }

        private List<string> SplitAlphabet(string alphabet)
        {
            return alphabet.Split(' ').ToList();
        }

        private string Translate(List<string> from, List<string> to, string unecryptedCharacter)
        {
            var indexOfUnencrypted = from.IndexOf(unecryptedCharacter);
            var encryptedCharacter = to[indexOfUnencrypted];

            return encryptedCharacter;
        }
    }
}