using System;
using System.Collections.Generic;
using System.Text;

namespace KWIC
{
    class Alphabetizer
    {
        static List<String> sortedShiftedLines = new List<String>();

        public static void AlphaSort()
        {
            sortedShiftedLines = CircularShifter.GetShiftedLines();
            sortedShiftedLines.Sort();
        }

        public static List<String> GetShiftedSortedLines()
        {
            return sortedShiftedLines;
        }
    }
}
