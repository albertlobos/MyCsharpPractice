// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("This is crazy");

Animal dog = new Animal("dog", 12, true);

Console.WriteLine(dog);
Console.WriteLine(dog.ToString());
Console.WriteLine(dog);
Console.WriteLine(dog.getAge() + "  " + dog.getType() + "  wIs it a pet?: " + dog.getIsPet());
Console.WriteLine(dog.GetType()); //Gives class type



class Animal
{
    private string _type;
    private int _age;
    private bool _isPet;

    public Animal(string type, int age, bool isPet)
    {
        _type = type;
        _age = age;
        _isPet = isPet;
    }

    public string getType()
    {
        return _type;
    }

    public int getAge()
    {
        return _age;
    }

    public bool getIsPet()
    {
        return _isPet;
    }
    
}