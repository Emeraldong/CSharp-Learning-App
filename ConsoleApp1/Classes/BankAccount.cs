namespace ConsoleApp1.Classes;

public class BankAccount
{
    private static int s_accountNumberSeed = 1234567890;
    public string id { get; }
    public string Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }

    public BankAccount(string name, decimal initialBalance)
    {
        this.Owner = name;
        this.id = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;

        makeDeposit(initialBalance, DateTime.Now, "Initial Balance");
    }

    private List<Transactions> _allTransactions = new List<Transactions>();
    public void makeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit Amount must be positive");
        }
        var deposit = new Transactions(amount, date, note);
        _allTransactions.Add(deposit);
    }

    public void makeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount > this.Balance)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Insufficient Balance to make withdrawal");
        }
        else if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal Amount must be positive");
        }

        var withdrawal = new Transactions(-amount, date, note);
        _allTransactions.Add(withdrawal);
    }

    public string getAccountHistory()
    {
        var report = new System.Text.StringBuilder();

        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");

        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }

        return report.ToString();
    }
}