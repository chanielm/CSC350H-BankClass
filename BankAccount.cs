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
    + Deposit(float): void
    + Withdraw(float): void
*/

class BankAccount
{
    string id;
    float balance;
    List<float> transactions;

    public string ID { get { return id; } }
    public float Balance { get { return balance; } }
    public List<float> Transactions { get { return transactions; } }

    public BankAccount(string id, float initbal)
    {
        this.id = id;
        this.balance = initbal;
        this.transactions = [];
    }

    public void Deposit(float amount)
    {
        balance += amount;
        transactions.Add(amount);
    }

    public void Withdraw(float amount)
    {
        balance -= amount;
        transactions.Add(-amount);
    }
}