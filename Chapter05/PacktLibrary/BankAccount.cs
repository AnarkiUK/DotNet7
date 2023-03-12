namespace Packt.Shared;

public class BankAccount
{
    public string AccountName; // Instance member
    public decimal Balance; // Instance member
    public static decimal InterestRate; // Shared member (all instances of BankAccount will share the same value)
}
