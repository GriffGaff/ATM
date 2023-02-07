using System;

public class CardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;

    public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public string GetNum()
    {
        return cardNum = "num";
    }

    public int GetPin()
    {
        return pin = 0000;
    }

    public string GetFirstName()
    {
        return firstName = "Abdul";
    }

    public string GetLastName()
    {
        return lastName = "Baqi";
    }

    public double GetBalance()
    {
        return balance = 2500.5;
    }
    //setting
    public void SetNum(string newCardNum)
    {
        cardNum = newCardNum;
    }

    public void SetPin(int newPin)
    {
        pin = newPin;
    }

    public void SetFirstName(string newFirstName)
    {
        firstName = newFirstName;
    }

    public void SetLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public void SetBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("CHOOSE FROM ONE OF THE FOLLOWING OPTIONS...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much would you like to deposit: ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.SetBalance(deposit);
            Console.WriteLine("Thank you. \nNew Balance: " + currentUser.GetBalance());
        }

        void withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            //check if the user has enough balance
            if(currentUser.GetBalance() > withdrawal)
            {
                Console.WriteLine("Insufficient balance:(");
            }
            else 
            {
                currentUser.SetBalance(currentUser.GetBalance() - withdrawal);
                Console.WriteLine("Thank you for banking with us.");
            }
        }

        void balance(CardHolder currentUser)
        {
            Console.WriteLine("Current balance; " + currentUser.GetBalance());
        }

        //prompt user
        Console.WriteLine("Wlcome to your personal ATM");
        Console.WriteLine
    }

}