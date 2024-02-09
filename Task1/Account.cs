public class Account
{
    public double Balance { get; set; }
    public double GetBalance(double sum)
    {
        return Balance + sum;
    }
}