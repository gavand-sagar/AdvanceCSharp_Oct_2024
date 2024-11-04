using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{

    public class AC
    {

        public void TurnON()
        {
            Console.WriteLine("Ac Turned On");
        }

        public void TurnOFF()
        {
            Console.WriteLine("Ac Turned Off");
        }
    }

    public class TV
    {

        public void TurnON()
        {
            Console.WriteLine("TV Turned On");
        }

        public void TurnOFF()
        {
            Console.WriteLine("TV Turned Off");
        }
    }

    public class UserActivityFacade
    {
        TV tV = new TV();
        AC aC = new AC();

        public void watchTV()
        {
            tV.TurnON();
            aC.TurnON();
        }

    }



    public class FacadeDemo : IExecutableClass
    {
        public void Execute()
        {
            UserActivityFacade userActivity = new UserActivityFacade();
            userActivity.watchTV();
        }
    }
}
