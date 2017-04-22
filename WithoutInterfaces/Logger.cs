using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
