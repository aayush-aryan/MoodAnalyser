using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserConsoleApp
{
   public class MoodAnalyserCustomException :Exception
    {
        //enum ExceptionType;
       public ExceptionType type;  
        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type=type;
        }
    }
}
