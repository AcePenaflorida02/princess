

class EntryPoint5{
    public static void Main(string[] args){
        Dog dog1 = new Dog();
        dog1.SetName(Console.ReadLine());

        dog1.Eat();
    }
}

abstract class Animal{
    public string Name{get; set;}

    public void SetName(string name){
        this.Name = name;
    }

    public string GetName(){
        return Name;
    }

    public abstract void Eat();

}


class Dog : Animal{
    public override void Eat(){
        Console.WriteLine($"{Name} is eating...");
    }
}