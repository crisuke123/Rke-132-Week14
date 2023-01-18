Console.WriteLine("Name your dog");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);


Dog neigboursDog = new Dog("Good Girl");



Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neibors dogs name is {neigboursDog.Name}.");


myDog.Rename("Bad boy");

while(myDog.LevelOfHapiness  != 5)
{
    myDog.Bark();
}
myDog.wagTail();


class Dog
{
    private string _name;//fild
    private int _levelOFHapiness;

    //construkctor
    public Dog (string name)// name - lets the user name the dog 
    {
        _name = name ;
        _levelOFHapiness = 0;
    }

    //getter

    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHapiness
    {
        get { return _levelOFHapiness;}
    }

    public void Rename(string newName)
    {
        _name= newName ;
        Console.WriteLine($"The dog has been renamed to; {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOFHapiness++;
    }

    public void wagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}


















