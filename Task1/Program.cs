using System.Threading.Tasks.Dataflow;

var account = new Account();
account.Balance = 100;
System.Console.WriteLine(account.GetBalance(20));