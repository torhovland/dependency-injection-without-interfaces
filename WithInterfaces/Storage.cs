using System;
using System.Threading.Tasks;

namespace WithInterfaces
{
    class Storage : IStorage
    {
        public async Task Save()
        {
            Console.WriteLine("Writing to a database here...");
            await Task.Delay(100);
        }
    }
}