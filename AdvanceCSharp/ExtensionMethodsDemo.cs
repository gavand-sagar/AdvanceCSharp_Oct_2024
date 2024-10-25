using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{


    public class Math {
        public int number;
        public Math(int number)
        {
            this.number = number;
        }
        public int doSquare()
        {
            return number * number;
        }
    }


    static class ExtentsionsClass { 
    
        public static int doCube(this Math obj)
        {
            return obj.doSquare() * obj.number;
        }
    
    }



    public class ExtensionMethodsDemo
    {
        public void Execute()
        {
            Math m = new Math(5);
            m.doCube();
        }
    }
}
