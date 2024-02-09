public class Counter
{
    public int Value { get; set; }
    public Counter(int value)
    {
        Value = value;
    }
    public void Decrement()
    {
        if(Value <= 0)
        {
            return;
        }
        else
        {
            Value --;
        }
    }
    public void Reset()
    {
        Value = 0;
    }
    public void PrintValue()
    {
        System.Console.WriteLine(Value);
    }
}