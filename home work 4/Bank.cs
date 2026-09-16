class BankAccount
{
    private int accountId;
    private decimal balance;
    public string OwnerName;
    private bool isFrozen;

    public BankAccount(int accountId, decimal balance, string ownerName)
    {
        this.accountId = accountId;
        this.balance = balance;
        OwnerName = ownerName;
        isFrozen = false;
    }

    public void Deposit(decimal amount)
    {
        if (isFrozen)
        {
            Console.WriteLine("Счет заморожен");
            return;
        }

        balance = balance + amount;
        Console.WriteLine("Внесено: " + amount);
        Console.WriteLine("Баланс: " + balance);
    }

    public void Withdraw(decimal amount)
    {
        if (isFrozen)
        {
            Console.WriteLine("Счет заморожен");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Недостаточно средств");
            return;
        }

        balance = balance - amount;
        Console.WriteLine("Снято: " + amount);
        Console.WriteLine("Баланс: " + balance);
    }

    public void FreezeAccount()
    {
        isFrozen = true;
        Console.WriteLine("Счет заморожен");
    }

    public void UnfreezeAccount()
    {
        isFrozen = false;
        Console.WriteLine("Счет разморожен");
    }
}