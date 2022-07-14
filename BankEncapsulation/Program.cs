using BankEncapsulation;

var myBankAccount = new BankAccount();

Console.WriteLine($"Hello, your bank account balance is {myBankAccount.GetBalance()}");

Console.WriteLine("Would you like to do a deposit or withdrawl?");
var answer = Console.ReadLine();
    if (answer == "withdrawl")
    {
        Console.WriteLine("How much would you like to withdraw?");
        double withdraw = double.Parse(Console.ReadLine());
        myBankAccount.Withdrawl(withdraw);
        Console.WriteLine($"Your new balance is ${myBankAccount.GetBalance()}");
    }

    else if (answer == "deposit")
    {
        Console.WriteLine("How much would you like to deposit?");
        double deposit = double.Parse(Console.ReadLine());
        myBankAccount.Deposit(deposit);  
        Console.WriteLine($"Your new balance is ${myBankAccount.GetBalance()}");
    }

    else
    {
        Console.WriteLine("No action taken, have a good day!");
    }
