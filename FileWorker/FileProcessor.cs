using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWorker
{
    class FileProcessor
    {
        private AbstractFileProcessor fileWorker;

        public AbstractFileProcessor FileWorker
        {
            get
            {
                return fileWorker;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("FileProcessor cannot be null");
                fileWorker = value;
            }
        }

        public FileProcessor(AbstractFileProcessor fileProcessor)
        {
            if (fileProcessor == null)
                throw new ArgumentNullException("Parametr fileProcessor cannot be null");
            this.fileWorker = fileProcessor;
        }

        public void ProcessFile(string fileName)
        {
            fileWorker.ProcessFile(fileName);
        }
    }
}
