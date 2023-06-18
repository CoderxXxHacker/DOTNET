

namespace BankApplication
{

    interface BankAccount
    {
        bool DepositAmount(decimal amount);

        bool WithdrawAmount(decimal amount);

        decimal CheckBalance();
    }
}