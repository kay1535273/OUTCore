using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUTCore.Dal.Repository
{
    public class FileRepositoryBase : IRepositoryBase
    {
        protected string FileName { get; private set; }

        protected FileRepositoryBase(string fileName)
        {
            FileName = fileName;
        }
    }
}
