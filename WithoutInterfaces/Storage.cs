using System;
using System.Threading.Tasks;

namespace WithoutInterfaces
{
    public class Storage
    {
        public async Task Save()
        {
            Console.WriteLine("Writing to a database here...");
            await Task.Delay(100);
        }
    }
}