using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{

    public interface IHandler
    {
        void Handle(string query);
        void SetNext(IHandler handler);
        IHandler GetNext();
    }

    public abstract class AbstractHandler : IHandler
    {
        private IHandler next = null;
        public IHandler GetNext()
        {
            return next;
        }

        public abstract string queryType { get; }

        public void Handle(string query)
        {
            if (query == queryType)
            {
                Execute();
            }
            else
            {
                if (GetNext() != null)
                {
                    GetNext().Handle(query);
                }
                else
                {
                    Console.WriteLine("Not Applicable.");
                }
            }
        }

        public abstract void Execute();

        public void SetNext(IHandler handler)
        {
            next = handler;
        }
    }

    public class GeneralTicketHandler : AbstractHandler
    {
        public override string queryType => "General";

        public override void Execute()
        {
            Console.WriteLine("Query solved by GeneralTicketHandler");
        }
    }
    public class SofwareTicketHandler : AbstractHandler
    {
        public override string queryType => "Software";

        public override void Execute()
        {
            Console.WriteLine("Query solved by SofwareTicketHandler");
        }

    }
    public class HardwareTicketHandler : AbstractHandler
    {
        public override string queryType => "Hardware";

        public override void Execute()
        {
            Console.WriteLine("Query solved by HardwareTicketHandler");
        }
    }

    public class NetworkTicketHandler : AbstractHandler
    {
        public override string queryType => "Network";

        public override void Execute()
        {
            Console.WriteLine("Query solved by Network Team.");
        }
    }


    public class ChainFactory
    {

        public static IHandler getHandlerChain()
        {
            IHandler handler1 = new HardwareTicketHandler();
            IHandler handler2 = (new SofwareTicketHandler());
            IHandler handler3 = (new GeneralTicketHandler());
            IHandler handler4 = (new NetworkTicketHandler());
            handler1.SetNext(handler2);
            handler2.SetNext(handler3);
            handler3.SetNext(handler4);
            return handler1;
        }

    }


    public class ChainOfResponsibility : IExecutableClass
    {
        public void Execute()
        {
            string query = "Software";

            IHandler handler = ChainFactory.getHandlerChain();
            handler.Handle(query);

        }
    }
}
