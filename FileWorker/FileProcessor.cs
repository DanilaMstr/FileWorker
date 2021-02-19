using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWorker
{
    class FileProcessor
    {
        public AbstractFileProcessor fileProcessor;

        public FileProcessor(AbstractFileProcessor fileProcessor) => this.fileProcessor = fileProcessor;

        public void ProcessFile(string fileName)
        {
            fileProcessor.ProcessFile(fileName);
        }
    }
}
