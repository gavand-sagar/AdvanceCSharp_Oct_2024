using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{

    public interface IExportable
    {
        void Export();
    }

    public class ExportToPDF : IExportable
    {
        public void Export()
        {
            Console.WriteLine("PDF Exported");
        }
    }

    public class ExportToWord : IExportable
    {
        public void Export()
        {
            Console.WriteLine("WORD Exported");
        }
    }

    //this is a third party library class 
    public class ExportTOPPT
    {
        public void CreatePPT()
        {
            Console.WriteLine("PPT Exported");
        }
    }


    public class ExportToPPTAdaptor : IExportable
    {
        ExportTOPPT _obj;
        public ExportToPPTAdaptor(ExportTOPPT obj)
        {
            this._obj = obj;
        }
        public void Export()
        {
            _obj.CreatePPT();
        }
    }

    public class AdaptorPatternDemo : IExecutableClass
    {
        public void Execute()
        {
            IExportable exportable1 = new ExportToPPTAdaptor(new ExportTOPPT());
            exportable1.Export();

        }
    }
}
