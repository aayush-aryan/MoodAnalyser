using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserConsoleApp;

namespace MoodAnalyserTestProject
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Follow AAA strategy
        /// Arrange , Act and in last Assert
        /// </summary>

        [TestMethod]
        [TestCategory("Happy Mood")]
        public void GivenMessageShouldReturnHappy()
        {
            AnalyzeMood analyzeMood = new AnalyzeMood();
            string message = "I am in Happy Mood";
            string excepted = "happy";
            var actual = analyzeMood.Mood(message);
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        /// Follow AAA strategy
        /// Arrange , Act and in last Assert
        /// </summary>

        [TestMethod]
        [TestCategory("SAD Mood")]
        public void GivenMessageShouldReturnSad()
        {
            AnalyzeMood analyzeMood = new AnalyzeMood();
            string message = "I am in SAD Mood";
            string excepted = "sad";
            var actual = analyzeMood.Mood(message);
            Assert.AreEqual(excepted, actual);
        }
    }
}
