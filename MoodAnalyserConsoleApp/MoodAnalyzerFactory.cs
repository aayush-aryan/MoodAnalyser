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
        /// <summary>
        /// factoryMethod to create   
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyserParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = Type.GetType(className);

            try
            {
                if (type.FullName.Equals(className) || type.Name.Equals(className))
                {
                    if (type.Name.Equals(constructorName))
                    {
                        ConstructorInfo info = type.GetConstructor(new[]   //searchesForPublicInstancesConstructor_whoseParametersMatch_typeInSpecifiedArray; and
                                                                           //returns object
                        {
                        typeof(string)                   //array initialization Syntax ; var c = new[] { 10, 20, 30 };CW(c.GetType());  // output: System.Int32[]
                    }
                        );
                        object instance = info.Invoke(new object[] { message }); // Invoke-returns instanceOfClass associatedWithConstructors.
                        return instance;                                         //Invoke the Constructor reflelected by the instance that has specified parameters; 
                    }
                    else
                    {
                        throw new MoodAnalyserCustomException(ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor not found");
                    }
                }
                else
                {
                    throw new MoodAnalyserCustomException(ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            catch (Exception exception)
            {
                // throw new MoodAnalyserCustomException(ExceptionType.NO_SUCH_CLASS, "Class not found");
                return exception;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        /// <param name="message"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static object CreateMoodAnalyserOptionalVariable(string className, string constructorName, string message, string msg = "I am optional variable")
        {
            Type type = Type.GetType(className);
            try
            {
                if (type.FullName.Equals(className) || type.Name.Equals(className))
                {
                    if (type.Name.Equals(constructorName))
                    {
                        ConstructorInfo info = type.GetConstructor(new[] { typeof(string) });
                        object instance = info.Invoke(new object[] { message });
                        return instance;
                    }
                    else
                    {
                        throw new MoodAnalyserCustomException(ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor not found");
                    }
                }
                else
                {
                    throw new MoodAnalyserCustomException(ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            catch (Exception exception)
            {
                return exception;
            }
        }
    }
}
