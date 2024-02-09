public class Account
{
    public double Balance { get; set; }
    public double HeikkisAccount(double bal)
    {
        return Balance - bal;
    }
    public double PersonalAccount(double bal)
    {
        return Balance + bal;
    }
    public string ToString()
    {
        return $"Heikki's account balance: {HeikkisAccount(100)}";        
    }
    public string ToStringg()
    {
        return $"Personal account balance: {PersonalAccount(100)}";
    }

    
}