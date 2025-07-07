using ConsoleApp1.Classes;

var account = new BankAccount("SAM", 1000);
account.makeDeposit(500, DateTime.Now, "Paid in beans");
Console.WriteLine(account.Balance);
account.makeWithdrawal(20, DateTime.Now.AddDays(-1), "Bought a hamburger");
Console.WriteLine(account.Balance);

Console.WriteLine($"Account {account.id} was created for {account.Owner} with a balance of {account.Balance}.");