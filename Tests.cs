using NUnit.Framework;
namespace SherlockAndAnagrams;

    [TestFixture]
    public class Tests
    {
        [TestCase("ifailuhkqq", 3)]
        [TestCase("abcd", 0)]
        [TestCase("abba", 4)]
        [TestCase("kkkk", 10)]
        [TestCase("cdcd", 5)]
        public void TestSherlockAndAnagrams(string s, int count)
        {
            Assert.AreEqual(count, Anagram.SherlockAndAnagrams(s));
        }
}