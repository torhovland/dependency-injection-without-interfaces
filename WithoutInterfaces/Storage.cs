using System;
using System.Threading.Tasks;

namespace WithoutInterfaces
{
    public class Storage
    {
        private readonly Logger logger;

        public Storage(Logger logger)
        {
            this.logger = logger;
        }

        public virtual async Task Save()
        {
            logger.Log("Writing to a database here...\n");
            await Task.Delay(100);
        }
    }
}