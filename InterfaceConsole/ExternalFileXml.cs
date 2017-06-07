using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole {

    class ExternalFileXml : IExternalFile {

        public string ToFile(string Message) {
            return "<xml>" + Message + "</xml>";
        }
    }
}
