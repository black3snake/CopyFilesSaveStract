using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFilesSaveStract
{
    internal interface IDataProvider
    {
        void FileCopy();
        int GetLengthFileName();
    }
}
