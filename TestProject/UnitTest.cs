using CodingDojo_Anagram;

namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void TestNotAnagram()
        {
            Assert.Equal(new List<Tuple<string, string>>(), Anagram.Find("lancer pouvoir etre avoir"));
        }

        [Fact]
        public void TestAnagram()
        {
            Assert.Equal(new List<Tuple<string, string>>() { }, Anagram.Find("carte oui actere"));
        }

        [Fact]
        public void TestAnagramWorks()
        {
            Assert.Equal(new List<Tuple<string,string>>() { new Tuple<string, string>("carte", "acter") }, Anagram.Find("carte oui acter"));
        }

        [Fact]
        public void TestAnagramWith10Words()
        {
            Assert.Equal(new List<Tuple<string, string>>() { new Tuple<string,string>("brag", "grab") }, Anagram.Find("element elite brag email empty energy grab"));
        }

        [Fact]
        public void TestAnagramWithTooMuchSpaces()
        {
            Assert.Equal(new List<Tuple<string, string>>() { new Tuple<string, string>("brag", "grab") }, Anagram.Find("element    elite brag email   empty energy       grab"));
        }
    }
}