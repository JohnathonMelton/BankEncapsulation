namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.WriteLine("Input desired deposit amount.");
            double amountToDeposit = double.Parse(Console.ReadLine());

            account.deposit(amountToDeposit);
            double userBalance = account.GetBalance();

            Console.WriteLine($"Your current balance is {userBalance, 0:c}.");



        }
    }
}
