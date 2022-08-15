using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserConsoleApp
{
    public class AnalyzeMood
    {
        //variable
        public string message;
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="message"></param>
        public AnalyzeMood(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// default Constructor
        /// </summary>
        public AnalyzeMood()
        {
        }
        //uc1
        /// <summary>
        /// Method to return the type of Mood
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string Mood(string message)
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
        //UC4
        /// <summary>
        ///exception handeled for
        ///passing null value returnd happy
        ///Method to return the type of Mood
        /// </summary>
        /// <returns></returns>
        public string Mood()
        {
            try
            {
                if (message == null)
                {
                    throw new MoodAnalyserCustomException(ExceptionType.NULL_EXCEPTION, "Message cann't be null");
                }
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(ExceptionType.EMPTY_EXCEPTION, "Message cann't be Empty");
                }
                message = message.ToLower();
                if (message.Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}
  