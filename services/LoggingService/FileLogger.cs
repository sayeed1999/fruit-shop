using System;
using System.IO;
using System.Text;

namespace fruit_shop
{
    class FileLogger : ILogger
    {
        public void Log(string content)
        {
            using(StreamWriter writer = new StreamWriter("output.txt", true)) //true to append to the file, false to overwrite the file
            {
                writer.WriteLine(content);
            }
        }
    }
}