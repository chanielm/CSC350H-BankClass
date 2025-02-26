Console.WriteLine("TESTING CONSTRUCTOR:\nID numbers are randomized and prefixed by the first 3 numbers of the account's name.\n");

// Testing Constructor
BankAccount ba = new(null, 1000.00f); // name is null
BankAccount bb = new("A", 1000.00f); // name is less than 3 characters
BankAccount bc = new("Tst", 1000.00f); // name is exactly 3 characters
BankAccount bd = new("Chaniel Mays", 1000.00f); // name is more than 3 characters

Console.WriteLine($"ID if name is null: {ba.ID}");
Console.WriteLine($"ID if name is less than 3 Characters \"A\": {bb.ID}");
Console.WriteLine($"ID if name is exactly 3 Characters \"Tst\": {bc.ID}");
Console.WriteLine($"ID if name is more than 3 Characters \"Chaniel Mays\": {bd.ID}");

// Testing Transactions
Console.WriteLine("\nTESTING TRANSACTIONS:\n");
BankAccount be = new("Balance Test", 1000.00f);
Console.WriteLine($"Initial Balance = {be.Balance}");

Console.WriteLine("\nDepositing a negative amount:");
be.Deposit(-1);
Console.WriteLine("Withdrawing a negative amount:");
be.Withdraw(-1);
Console.WriteLine("Withdrawing a positive amount, greater than the balance");
be.Withdraw(3000.00f);

Console.WriteLine("\nDepositing a positive amount:");
be.Deposit(500.00f);
Console.WriteLine("Withdrawing a positive amount, less than the balance:");
be.Withdraw(500.00f);

Console.WriteLine("\nAdding more transactions:");
be.Deposit(1999.99f);
be.Withdraw(349.97f);
be.Withdraw(254.79f);
be.Deposit(200.43f);

Console.WriteLine("\nTransactions (Positive=Deposit, Negative=Withdraw, Failed Not Included)");
foreach (float trans in be.Transactions) Console.WriteLine(trans < 0 ? trans : "+" + trans);

Console.WriteLine($"\nFinal Balance = {be.Balance}");