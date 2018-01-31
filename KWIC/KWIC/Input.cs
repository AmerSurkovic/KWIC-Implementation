using System;
using System.Collections.Generic;
using System.Text;

namespace KWIC
{
    class Input
    {
        public static void Parse(string filePath)
        {
            List<String> listOfLines = LineStorage.AddLines(filePath + ".txt");
        }
    }
}
