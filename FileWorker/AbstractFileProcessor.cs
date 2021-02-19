using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWorker
{
    abstract class AbstractFileProcessor
    {
        public void ProcessFile(string fileName)
        {
            if (File.Exists(fileName) && Path.GetExtension(fileName).Contains(GetFormat()))
                StartWork(fileName);
            else
                Console.WriteLine("incorrect file format or file not exist");
        }

        protected abstract string GetFormat();
        protected abstract void StartWork(string fileName);
    }
}
