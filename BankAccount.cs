/*
Class: BankAccount
    Fields:
    - id: string
    - balance: float
    - transactions: List<float>
    Properties:
    + ID: string
    + Balance: float
    + Transactions: List<float>
    Methods:
    + Deposit(float): bool
    + Withdraw(float): bool
*/

class BankAccount
{
    string id;
    float balance;
    List<float> transactions;

    public string ID { get { return id; } }
    public float Balance { get { return balance; } }
    public List<float> Transactions { get { return transactions; } }

    public BankAccount(string? name, float initbal)
    {
        if (name != null) name = name.Replace(" ", null);
        this.id = (name == null || name.Length < 3) ? "Acc" : name.Substring(0, 3);
        Random r = new();
        for (int i = 0; i < 5; i++) id += r.Next(10);

        this.balance = initbal;
        this.transactions = [];
    }

    public bool Deposit(float amount)
    {
        if (amount < 0) 
        {
            Console.WriteLine("FAILED: Cannot deposit a negative amount!");
            return false;
        }
        
        balance += amount;
        Console.WriteLine("DEPOSIT SUCCESS.");
        transactions.Add(amount);
        return true;
    }

    public bool Withdraw(float amount)
    {
        if (amount < 0) 
        {
            Console.WriteLine("FAILED: Cannot withdraw a negative amount!");
            return false;
        }

        if (balance < amount) 
        {
            Console.WriteLine("FAILED: Insufficient Funds!");
            return false;
        }
        

        balance -= amount;
        Console.WriteLine("WITHDRAW SUCCESS.");
        transactions.Add(-amount);
        return true;
    }
}