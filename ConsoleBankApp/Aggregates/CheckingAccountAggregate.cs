using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankApp.Aggregates
{
    public interface ICheckingAccountAggregate
    {
        float Withdraw(float amount, string currency);
        float Deposit(float amount, string currency);
    }
}
