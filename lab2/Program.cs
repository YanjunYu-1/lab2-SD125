
abstract class Account//Abstract class: cannot be accessed and can contain abstract methods whose contents need to be inherited by other classes to be used
{
    //Encapsulation: Instead of using properties directly, get and set are used to call properties to prevent users from accidentally corrupting data
    private int Id { get; set; }
    private int customerId { get; set; }
    double Balance { get; set; }
    private int AccountNumber = 1;
    public abstract void AccountInformation();//Abstract methods: Can only be in the abstract class, there is no content, can only be written by other classes (classes that inherit abstract clas    
}



public class SavingAccount : Account //Inheritance: SavingAccount is a parent class and SavingAccount is a subclass. ":" indicates that SavingAccount inherits from Account. After inheritance, functions and attributes in an Account become part of SavingAccount and can be directly used by SavingAccount
{
    public SavingAccount(int id, int customerid, double balance)
    {
        Id = id;
        customerId = customerid;
        Balance = balance;
        AccountNumber++;
    }

    public override void AccountInformation()
    {
        Console.WriteLine("Saving Account");//Abstract method: Because SavingAccount inherits Account (abstract class), you can override this method in SavingAccount with the keyword Override
    }

    //Polymorphism: Two methods can have the same name and return value types, but the arguments in parentheses cannot be the same
    public void TalkAboutAccount(int Id)
    {
        Console.WriteLine($"My Id is {Id}");
    }
    public void TalkAboutAccount(int Id,double Balance)
    {
        Console.WriteLine($"My Balance is {Balance}");
    }
    

    public class CheckingAccount : Account
    {
        public CheckingAccount(int id, int customerid, double balance)
        {
            Id = id;
            customerId = customerid;
            Balance = balance;
            AccountNumber++;
        }
    }
}