﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_Day20
{
    public class NullException
    {
        public void shownullException(string message)
        {
            if (message == null)
            {
                throw (new MoodAnalysisException("Enterd Null Input"));
            }
            else if (message == "")
            {
                throw (new MoodAnalysisException("Empty Mood"));
            }
        }
    }
}
