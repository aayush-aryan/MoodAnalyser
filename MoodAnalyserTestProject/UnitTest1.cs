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
        /// <summary>
        /// TC-4.1 Returns the mood analyser object
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserReflection_ShouldReturnObject()
        {
            object expected = new AnalyzeMood();
            object actual = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserConsoleApp.AnalyzeMood", "AnalyzeMood");
            expected.Equals(actual);
        }
        /// <summary>
        /// TC-4.2 should throw NO_SUCH_CLASS exception.
        /// </summary>
        [TestMethod]
        public void GivenClassNameIsImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserWrong.AnalyzeMood", "AnalyzeMood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// TC-4.3 should throw NO_SUCH_CONTRUCTOR exception.
        /// </summary>
        [TestMethod]
        public void GivenConstructorNameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserConsoleApp.AnalyzeMood", "AnalyzeMoodWrong");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}
