using System;
using System.Collections.Generic;
using System.Text;

namespace KWIC
{
    class Output
    {
        public static void Print(string filePath)
        {
            System.IO.File.AppendAllLines(filePath + ".txt", Alphabetizer.GetShiftedSortedLines());
        }
    }
}
