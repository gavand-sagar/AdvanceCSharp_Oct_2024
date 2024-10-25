using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    public class DelgatesExamples
    {

        Action DoSomething;

        public string name = "";


        public Action DisplayMyName;
        
        public Action BeforeStart;
        public Action OnSuccess;
        public Action OnError;
        

        public void Execute()
        {
            BeforeStart();
            Console.WriteLine("Data base operation stared ");
            Console.WriteLine("Saving");
            OnSuccess();
            Console.WriteLine("Successfull");
        }

    }
}
