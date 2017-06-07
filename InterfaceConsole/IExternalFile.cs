using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole {

    public interface IExternalFile {
        string ToFile(string Message);
    }
}
