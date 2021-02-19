using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWorker
{
    class JsonProcess : AbstractFileProcessor
    {
        protected override string GetFormat() => ".json";

        protected override void StartWork(string fileName)
        {
            Console.WriteLine("Process with json file");
        }
    }
}
