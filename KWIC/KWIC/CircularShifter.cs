using System;
using System.Collections.Generic;
using System.Text;

namespace KWIC
{
    class CircularShifter
    {
        static List<String> shiftedLines = new List<String>();

        public static void Setup()
        {
            for(int i = 0; i < LineStorage.SizeOf(); i++)
            {
                string lineToShift = LineStorage.GetLine(i);

                // Shift the line app logic
                //
                List<String> tempShiftedLines = new List<String>();

                String[] words = lineToShift.Split(' ');
                for(int j = 0; j<words.Length; j++)
                {
                    string line = "";
                    foreach(string t in words)
                    {
                        line += " ";
                        line += t;
                    }
                    shiftedLines.Add(line);

                    string temp = words[0];
                    Array.Copy(words, 1, words, 0, words.Length-1);
                    words[words.Length - 1] = temp;
                }

                //
                //
            }
        }

        public static string GetLine(int index)
        {
            return shiftedLines[index];
        }

        public static List<String> GetShiftedLines()
        {
            return shiftedLines;
        }
    }
}
