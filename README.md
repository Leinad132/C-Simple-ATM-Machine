C#-Simple-ATM-Machine

Language and Frameworks, C# and .NET: The entire application is written in C#, which is an object-oriented programming language known for its simplicity, readability, and robustness. Object-Oriented Programming (OOP): The program utilizes OOP principles by defining a custom class atmUser to represent ATM users. This class encapsulates user data and provides methods for performing various banking operations.

Console Input and Output: The program uses the console for input and output interactions. It prompts the user to enter their card number and PIN and displays options for performing banking transactions.

Exception Handling: To handle unexpected user inputs or invalid PINs/card numbers, the program implements exception handling to ensure a smooth user experience.

Lists and LINQ: The program utilizes a List of atmUser instances to simulate multiple ATM users. LINQ (Language-Integrated Query) is used to search for user data based on card numbers and PINs.

How to Use When the program starts, it will prompt the user to enter their card number and PIN.

If the card number or PIN is not recognized, the user will be prompted to re-enter the correct information.

Upon successful authentication, the user will be greeted with their first name and presented with a menu of available options (Deposit, Withdraw, Show Balance, and Exit).

The user can choose an option by entering the corresponding number.

For deposit and withdrawal operations, the user will be prompted to enter the amount, and the program will update the account balance accordingly.

The program ensures that the user cannot withdraw more money than their account balance.

The user can view their updated account balance by selecting the "Show Balance" option.

To exit the program, the user can choose the "Exit" option.

