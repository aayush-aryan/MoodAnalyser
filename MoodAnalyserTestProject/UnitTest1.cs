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
            //Arrange
            AnalyzeMood analyzeMood = new AnalyzeMood();
            string message = "I am in Happy Mood";
            string excepted = "happy";
            //Act
            var actual = analyzeMood.Mood(message);
            //Assert
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
        /*
        //UC2 testcase
        [TestMethod]
        [TestCategory("Null")]
        [DataRow(null)]
        // this will pass in method as a message body;
        public void GivenNullShouldReturnHappy(string message)
        {
            ///Follow AAA strategy
            ///Arrange , Act anAssertd in last 
            AnalyzeMood analyzeMood = new AnalyzeMood(message);
            string excepted = "happy";
            var actual = analyzeMood.Mood();
            Assert.AreEqual(excepted, actual);
        }
        */
        /// <summary>
        /// given message should throw moodAnalysisException
        /// when passing message as Null;
        /// </summary>
        [TestMethod]
        public void Given_Null_Mood_should_ThrowMoodAnalysisCustomException()
        {
            try
            {
                string message = null;
                AnalyzeMood analyzeMood = new AnalyzeMood(message);
                string actual = analyzeMood.Mood();
            }
            catch (MoodAnalyserCustomException moodAnalyserCustomException)
            {
                Assert.AreEqual("Message can't be Null", moodAnalyserCustomException.Message);//get a Message that describe current Exception
            }
        }

        [TestMethod]
        public void Given_Empty_Mood_should_ThrowMoodAnalysisCustomException()
        {
            try
            {
                string message = "";
                AnalyzeMood analyzeMood = new AnalyzeMood(message);
                string actual = analyzeMood.Mood();
            }
            catch (MoodAnalyserCustomException moodAnalyserCustomException)
            {
                Assert.AreEqual("Message can't be Empty", moodAnalyserCustomException.Message);//get a Message that describe current Exception

            }
        }
    }
}
