using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class DependencyInjectionDemo : IExecutableClass
    {
        IDatabase database;
        ILogger logger;
        IWalker walker;
        public DependencyInjectionDemo(IDatabase database,ILogger logger, IWalker walker)
        {
            this.database = database;
            this.logger = logger;
            this.walker = walker;
        }
        public void Execute()
        {
            logger.Log("This logger dependency is getting injected in the constructor automatically.");
            walker.walk();
        }
    }
}
