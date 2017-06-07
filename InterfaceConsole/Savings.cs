using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole {

    public class Savings : IAccount {

        public void Display() {

        }

        public bool Deposit(double amount) {
            throw new NotImplementedException();
        }

        public bool Transfer(double amount, IAccount toAcct) {
            throw new NotImplementedException();
        }

        public bool Withdraw(double amount) {
            throw new NotImplementedException();
        }
    }
}
