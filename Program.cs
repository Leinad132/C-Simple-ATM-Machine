using System;


public class atmUser
{// Class properties to store user information
    String cardNumber; 
    int pin;
    String firstName;
    String lastName;
    double balance;


    public atmUser(string cardNumber, int pin, string firstName, string lastName, double balance)
    {   // Constructor to initialize user information
        this.cardNumber = cardNumber;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    
    public String getCardNumber()     // Getter methods to access user information
    {
        return cardNumber;
    }
    public int getPin()
    {
        return pin;
    }
    public String getFirstName()
    {
        return firstName;
    }
    public String getLastName()
    {
        return lastName;

    }
    public double getBalance()
    {
        return balance;
    }
    // Setter methods to update user information
    public void setNum(String newCardNumber) 
    {
        cardNumber = newCardNumber;
    }
    
    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }
    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public void setPin (int newPin)
    {
        pin = newPin;
    }

    public static void Main(String[] args)
    {  // Function to display available options
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");

        }
        // Function to handle deposit
        void deposit(atmUser currentUser)

        {
            Console.WriteLine("How much $ would you like to deposit?");
            double deposit = double.Parse(Console.ReadLine());
            
            currentUser.setBalance(deposit + currentUser.balance);
            Console.WriteLine("Thank you for your deposit. Your new balance is "+ currentUser.getBalance());

        }
        // Function to handle withdrawal
        void withdraw(atmUser currentUser)
        {
            Console.WriteLine("How much $ would you like to withdraw?");
            double withdrawal = double.Parse(Console.ReadLine());
            // check if the user has enough money to withdraw
            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient Balance");  // Check if the user has enough money to withdraw
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Your new balance is  "+ currentUser.getBalance());
                
            }
        }
        // Function to display current balance

        void balance(atmUser currentUser)
        {
                Console.WriteLine("Current balance "+ currentUser.getBalance());
        }
        // Creating a list of 'atmUser' instances (simulating the ATM users' data)
            List<atmUser> accounts = new List<atmUser>();
            accounts.Add(new atmUser("4532 6897 0158 7632",1234,"John","Doe",3430.20));
            accounts.Add(new atmUser("3782 4589 1023 7465", 4321, "Mike", "Smith", 2200.23));
            accounts.Add(new atmUser("5410 6729 3568 8210", 3214, "Elsa", "Johnson", 55000.32));
            accounts.Add(new atmUser("6011 7890 2345 8765", 5678, "Amanda", "Martinez", 1443.23));

            //prompt the user to enter their information

            Console.WriteLine("Welcome to Daniel's ATM");
            Console.WriteLine("Please enter your card number ");
            String debitCardNum = "";
            atmUser currentUser;
        // Loop until a valid card number is entered
        while (true)
        {
            try
            { // Attempt to find the user with the entered card number
                debitCardNum = Console.ReadLine();
                currentUser = accounts.FirstOrDefault(a => a.cardNumber ==debitCardNum);
                if(currentUser != null) { break; }
                else 
                {
                    Console.WriteLine("Card not recognized");
                }
                
            }
            catch {
                Console.WriteLine("Card not recognized");
                  }
        }

        Console.WriteLine("Please enter your Pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {  // Loop until a valid PIN is entered
                userPin = int.Parse(Console.ReadLine());
                currentUser = accounts.FirstOrDefault(a => a.pin == userPin);    // Attempt to find the user with the entered PIN

                if (currentUser.getPin() ==  userPin) { break; }
                else
                {
                    Console.WriteLine("Pin not recognized");
                }

            }
            catch
            {
                Console.WriteLine("Pin not recognized");
            }
        }

        Console.WriteLine("Welcome "+ currentUser.getFirstName());
        int option = 0;
        do
        {   // Main menu loop
            printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch 
            {
                // Handling invalid input (non-numeric option)
            }
            if (option == 1) 
            {
                deposit(currentUser);
            }
            else if (option == 2)
            {
                withdraw(currentUser);
            }
            else if (option == 3)
            {
                balance(currentUser);

            }
            else if(option == 4)
            {
                break;
            }
            else
            {// Invalid option entered, reset the option value and display the menu again
                option = 0;
            }
        }
        while (option != 4);
        {
            Console.WriteLine("Thank you, have a nice day");
        }

    }
}
