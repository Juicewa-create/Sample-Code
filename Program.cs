namespace MySuperBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char pesoSymbol = '\u20B1';

            var account = new BankAccount("Joshua", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {pesoSymbol}{account.Balance} initial balance.");

            account.MakeWithdrawal(7000, DateTime.Now, "Smartphone");
            Console.WriteLine($"\nYou paid {pesoSymbol}7000 for Smartphone");
            Console.WriteLine($"Your Current Account Balance is: {pesoSymbol}{account.Balance}");
            
            account.MakeDeposit(2500, DateTime.Now, "Allowance");
            Console.WriteLine($"\nYou've Deposited {pesoSymbol}2500");
            Console.WriteLine($"Your Current Account Balance is: {pesoSymbol}{account.Balance}");

            account.MakeWithdrawal(4000, DateTime.Now, "Table");
            Console.WriteLine($"\nYou paid {pesoSymbol}4000 for Table");
            Console.WriteLine($"Your Current Account Balance is: {pesoSymbol}{account.Balance}");

            account.MakeDeposit(2500, DateTime.Now, "Savings");
            Console.WriteLine($"\nYou've Deposited {pesoSymbol}2500");
            Console.WriteLine($"Your Current Account Balance is: {pesoSymbol}{account.Balance}");

            account.MakeWithdrawal(1000, DateTime.Now, "Shirt");
            Console.WriteLine($"\nYou paid {pesoSymbol}1000 for Shirt");
            Console.WriteLine($"Your Current Account Balance is: {pesoSymbol}{account.Balance}");


            Console.WriteLine(account.GetAccountHistory());
        }
    }
}