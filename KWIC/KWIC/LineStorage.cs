using System;
using System.Collections.Generic;
using System.Text;

namespace KWIC
{
    class LineStorage
    {
        static List<String> lines = new List<string>();

        public static List<String> AddLines(string filePath)
        {
            string[] read = System.IO.File.ReadAllLines(filePath);
            foreach(string x in read)
            {
                lines.Add(x);
            }

            return lines;
        }

        public static string GetLine(int index)
        {
            return lines[index];
        }

        public static int SizeOf()
        {
            return lines.Count;
        }
    }
}
