using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceConsole {

    class Program {

        void Run() {
            IExternalFile extFile = null;
            string message = "Hello, world!";
            var toJson = false;
            if(toJson) {
                extFile = new ExternalFileJson();
            } else {
                extFile = new ExternalFileXml();
            }
            var formattedMessage = extFile.ToFile(message);
            MessageBox.Show(formattedMessage);
        }

        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
