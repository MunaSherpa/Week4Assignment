public class BankAccount
{
    private string accountNumber;
    private decimal balance = 0;

    public BankAccount(string accountNumber, decimal balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;

        Console.Write(" Your Account Number is" + accountNumber +"and"+"Your balance is"+balance);
    } 
    
    public decimal Deposite(decimal amount)
    {
        Console.WriteLine("Rs" + amount + "has been deposited in your account");
        return balance += amount;
    }

    public decimal Withdraw(decimal amount)
    {
        Console.WriteLine("Rs" + "has been withdraw from your account");
        return balance += amount;
    }

    public decimal finalBanace()
    {
        Console.WriteLine("Your final balance is Rs " + balance);
        return balance;
    }
}