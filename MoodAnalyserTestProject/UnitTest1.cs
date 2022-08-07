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
        /// <summary>
        ///Follow AAA strategy
        ///Arrange , Act and in last Assert
        /// </summary>

        [TestMethod]
        [TestCategory("Happy Mood")]
        public void GivenMessageShouldPassThroughConstructorReturn_Happy()
        {
            //Arrange
            AnalyzeMood analyzeMood = new AnalyzeMood("I am in Happy Mood");
            string excepted = "happy";
            //Act
            var actual = analyzeMood.Mood();
            ///Assert
            Assert.AreEqual(excepted, actual);
        }
        /// <summary>
        ///Follow AAA strategy
        ///Arrange , Act and in last Assert
        /// </summary>
        [TestMethod]
        [TestCategory("SAD Mood")]
        public void GivenMessageShoulPassThroughConstructorReturn_Sad()
        {
            AnalyzeMood analyzeMood = new AnalyzeMood("I am in SAD Mood");
            string excepted = "sad";
            var actual = analyzeMood.Mood();
            Assert.AreEqual(excepted, actual);
        }
        //UC2 testcase
        [TestMethod]
        [TestCategory("Null")]
        [DataRow(null)]
        // this will pass in method as a message body;
        public void GivenNullShouldReturnHappy(string message)
        {
            ///Follow AAA strategy
            ///Arrange , Act and in last Assert
            AnalyzeMood analyzeMood = new AnalyzeMood(message);
            string excepted = "happy";
            var actual = analyzeMood.Mood();
            Assert.AreEqual(excepted, actual);
        }
    }
}
