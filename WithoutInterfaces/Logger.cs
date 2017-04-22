using System;
using System.Text;

namespace WithoutInterfaces
{
    public class Logger
    {
        StringBuilder stringBuilder = new StringBuilder();

        public void Log(string message)
        {
            stringBuilder.Append(message);
        }

        public override string ToString()
        {
            return stringBuilder.ToString();
        }
    }
}
