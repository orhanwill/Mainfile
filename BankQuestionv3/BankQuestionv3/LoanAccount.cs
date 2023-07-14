using System;
using System.Collections.Generic;
using System.Text;

namespace BankQuestionv3
{
    public class LoanAccount : BankAccount, IBankAccount,ITransaction
    {
        public double LoanDuration { get; set; }
    }
}
