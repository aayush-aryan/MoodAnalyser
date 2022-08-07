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
        //UC2
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
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
                return "happy";
            }
        }
    }
}
