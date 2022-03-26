using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M3_Word_Occurrence_Calculator;

namespace WordOccurrenceTests
{
    [TestFixture]
    public class WordCalculatorTest
    {
        [Test]
        public void CalculateOccurrencesTest()
        {
            // arrange
            string wordString = "test test test";
            List<string> words = new List<string>(wordString.Split(' '));

            var expectedWord = new WordOccurrence();
            expectedWord.Word = "test";
            expectedWord.Count = 3;
            List<WordOccurrence> returnList = new List<WordOccurrence>();
            returnList.Add(expectedWord);

            // act
            var actual = WordCalculator.CalculateOccurrences(words);
            var expected = returnList;

            // assert
            Assert.AreEqual(expected[0].Word, actual[0].Word, "Invalid Word returned.");
            Assert.AreEqual(expected[0].Count, actual[0].Count, "Invalid Count returned.");
        }

        [Test]
        public void CalculateOccurrencesShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => { WordCalculator.CalculateOccurrences(null); });
        }
    }
}
