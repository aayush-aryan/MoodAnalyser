using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserConsoleApp
{
   public class AnalyzeMood
    {
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
    }
}
