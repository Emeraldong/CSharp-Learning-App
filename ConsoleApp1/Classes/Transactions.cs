namespace ConsoleApp1.Classes;

public class Transactions
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transactions(decimal amount, DateTime date, string notes)
    {
        this.Amount = amount;
        this.Date = date;
        this.Notes = notes;
    }
}