using System;

namespace BankApplication
{

    public class SavingAccount : BankAccount
    {

        private decimal Balance = 0;

        private readonly decimal perDayWithdrawLimit = 1000;

        private decimal TodayWithDrawal = 0;

        public bool DepositAmount(decimal Amount)
        {

            Balance += Amount;

            Console.WriteLine($"You have Deposited: {Amount}");
            Console.WriteLine($"Your Account Balance: {Balance}");
            return true;
        }

            public bool WithdrawAmount(decimal Amount)
        {
            if (Balance < Amount)
            {
                Console.WriteLine("You have Insufficient balance!");
                return false;
            }
            else if (TodayWithDrawal + Amount > perDayWithdrawLimit)
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }
            else
            {
                Balance = Balance - Amount;
                TodayWithDrawal = TodayWithDrawal + Amount;
                Console.WriteLine($"You have Successfully Withdraw: {Amount}");
                Console.WriteLine($"Your Account Balance: {Balance}");
                return true;
            }

            
        }

        public decimal CheckBalance()
            {
                return Balance;
            }
    }
}