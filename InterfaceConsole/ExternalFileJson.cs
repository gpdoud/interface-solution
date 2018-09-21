using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole {

    public class ExternalFileJson : IExternalFile {

        public string Debug() {
            return string.Empty;
        }
        public string ToFile(string Message) {
            return "{'file': '" + Message + "'}";
        }
    }
}
