using ConsoleApp1.Classes;
using Microsoft.Data.SqlClient;
using MongoDB.Driver;

var account = new BankAccount("SAM", 1000);
account.makeDeposit(500, DateTime.Now, "Paid in beans");
Console.WriteLine(account.Balance);
account.makeWithdrawal(20, DateTime.Now.AddDays(-1), "Bought a hamburger");
Console.WriteLine(account.Balance);

Console.WriteLine($"Account {account.id} was created for {account.Owner} with a balance of {account.Balance}.");
Console.WriteLine(account.getAccountHistory());

// SqlConnection connection = new SqlConnection();


// connection.ConnectionString =
// "Data Source = mongodb://127.0.0.1:27017;" +
// "Initial Catalog = tutorialDB;";

try
{
    // connection.Open();
    var client = new MongoClient("mongodb://127.0.0.1:27017");
    client.GetDatabase("tutorialDB");
    Console.WriteLine("successfully connected to DB.");
}
catch (Exception e)
{
    Console.WriteLine("Error.");
    Console.WriteLine(e.Message);
    return -1;   
}

return 0;