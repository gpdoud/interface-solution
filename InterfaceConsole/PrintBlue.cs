﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole {

    public class PrintBlue : IPrintColor {

        public string Print(string Message) {
            return "<blue>" + Message + "</blue>";
        }
    }
}
