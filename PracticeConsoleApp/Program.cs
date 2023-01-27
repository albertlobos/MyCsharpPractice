// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("This is crazy");

Animal dog = new Animal("dog", 12, true);

Console.WriteLine(dog);
Console.WriteLine(dog.ToString());
Console.WriteLine(dog);
Console.WriteLine(dog.getAge() + "  " + dog.getType() + "  wIs it a pet?: " + dog.getIsPet()); //Practicing with C#
Console.WriteLine(dog.GetType()); //Gives class type

Console.WriteLine("\n\\\\\\\\Just added this line to practice some things with git////");

/*Trying to get better at Git so i am writing this to add it and then commit it. I will then push this onto the remote
 project on github*/
//Okay this i will only add into the newBranch Repo

//Created a remote project and connected this local git to that one.
//Added this into the new branch called newBranch
//still practicing more with git
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