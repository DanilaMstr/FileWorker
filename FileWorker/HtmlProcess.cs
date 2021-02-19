using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWorker
{
    class HtmlProcess : AbstractFileProcessor
    {
        protected override string GetFormat() => ".html";

        protected override void StartWork(string fileName)
        {
            Console.WriteLine("Process with html file");
        }
    }
}
