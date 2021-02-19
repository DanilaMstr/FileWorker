using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWorker
{
    class TextProcess : AbstractFileProcessor
    {
        protected override string GetFormat() => ".txt";

        protected override void StartWork(string fileName)
        {
            Console.WriteLine("Process with txt file");
        }
    }
}
