public class Dog
{
    string _name;
    string _breed;
    int _year;
    public Dog(string name,string breed,int year)
    {
        _name = name;
        _breed = breed;
        _year = year;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetBreed()
    {
        return _breed;
    }
    public int GetYear()
    {
        return _year;
    }
    public string ToString()
    {
        return $"Sag bo nomi {_name} porodai {_breed} va solash {_year} gum shudaast. ";
    }

}