using static System.Console;

namespace fruit_shop
{
    class ConsoleLogger : ILogger
    {
        public void Log(string content)
        {
            WriteLine(content);
        }
    }
}