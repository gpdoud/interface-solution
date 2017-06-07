using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConsole {

    public interface IAccount {

        bool Deposit(double amount);
        bool Withdraw(double amount);
        bool Transfer(double amount, IAccount toAcct);

    }
}
