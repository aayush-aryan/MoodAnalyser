using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserConsoleApp
{
   public class MoodAnalyzerFactory
    {
        /// <summary>
        /// CreateMoodAnalyse method to create object of AnalyseMood class.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyse(string className, string constructorName)  //"MoodAnalyserConsoleApp.AnalyzeMood", "AnalyzeMood"
        {
            // create the pattern and checks whether constructor name and class name are equal
            string pattern = @"." + constructorName + "$";  
            Match result = Regex.Match(className, pattern);
            // if true then create object.
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                // if no class found then then throw class not found exception
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserCustomException(ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            // if constructor name not equal to class name then throw constructor not found exception
            else
            {
                throw new MoodAnalyserCustomException(ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor not found");
            }
        }
                
    }
}
