using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            FileProcessor fp = new FileProcessor(new HtmlProcess());
            fp.ProcessFile(@"C:\Users\danil\source\repos\FileWorker\FileWorker\hello.html");

            //fp.fileProcessor = new TextProcess();
            //fp.ProcessFile(@"C:\Users\danil\source\repos\FileWorker\FileWorker\hello.txt");

            //fp.fileProcessor = new JsonProcess();
            //fp.ProcessFile(@"C:\Users\danil\source\repos\FileWorker\FileWorker\hello.json");

            Console.ReadLine();
        }
    }
}
