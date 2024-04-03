
using oop_concepts.aoop_codes;

class Oop
{
    public static void Bitch(string[] args){
        // InvokeConstructors();
        // Inheritance();
        // CriminalLawyer crimLawyer1 = new CriminalLawyer("Ace", 21, 20, true, 200, 199);
        
        // Animal dog1 = new Dog(); // ! Abstraction Object
        // dog1.MakeSound(); 

        // Circle circle = new Circle(); // ! Interface Object
        // circle.Draw();
        // circle.Resize(78, 12);

        // Person doctor1 = new Doctor("Ace", 40); // ? 1) Polymorphism Object
        // IDrawable circle = new Circle(); // ? 2) Polymorphism Object
        // circle.Draw();
        // IDrawable square = new Square(); // ? 3) Polymorphism Object
        // square.Draw();

        

    }

    public static void InvokeConstructors(){
        Persona person1 = new Persona("ace", 19);
        person1.SayHello();

        Persona person2 = new Persona();
        person2.SayHello();

        // ! Via Constructor Chaining
        Persona person3 = new Persona(20);
        person3.SayHello();
    }


    public static void Inheritance(){
        Lawyer lawyer1 = new Lawyer("Jude", 21);
        lawyer1.Name = "Ace";
        lawyer1.Age = 20;
        lawyer1.SayHello();

        Lawyer lawyer2 = new Lawyer();

        Lawyer lawyer3 = new Lawyer("Ace", 21, 10, true);
    }


}


public class Persona{

    private string name; // accessible to base class only
    private int age;

    // ! Constructor Overloading
    public Persona(string name, int age){ // parameterized constructor
        this.name = name;
        this.age = age;
    }

    public Persona(){ // non-parameterized constructor
        this.name = "";
        this.age = 0;
    }

    // ! Constructor Chaining
    public Persona(int age) : this("Undeclared", age){
    }


    // ! Getters and Setters
    public string Name{
        get { return name; }
        set { name = value; }
    }

    public int Age{
        get { return age; }
        set { age = value; }
    }


    // ! Methods
    public void SayHello(){
        Console.WriteLine($"I am {name} and I am {age} years old.");
    }


    protected void SomeProtectedMethod(){
        Console.WriteLine("Protected Method: Accessible to the subclasses.");
    }

    public virtual void MethodToBeOverriden(){
        Console.WriteLine("This method is overriden");
    }


}


public class Lawyer : Persona{
    
    private int careerDuration;
    private bool governmental;

    public int CareerDuration{
        get { return careerDuration;}
        set { careerDuration = value;}
    }

    public bool Governmental{
        get { return governmental; }
        set { governmental = value; }
    }

    public Lawyer(string name, int age) : base(name, age){
        SomeProtectedMethod();
        SayHello();
    }

    public Lawyer() : base("Undeclared", 0){ // ! constructor chaining
        SayHello();
    }


    private void SomePrivateMethod(){
        Console.WriteLine("Not Accessible to subclass.");
    }


    protected void WorkStatus(){
        if (this.governmental == true){
            Console.WriteLine($"I work for the government for {this.careerDuration} years.");
        }else{
            Console.WriteLine($"I work for the private sector for {this.careerDuration} years.");
        }
    }

    public Lawyer(string name, int age, int careerDuration, bool governmental): base(name, age){
        this.careerDuration = careerDuration;
        this.governmental = governmental;
        SayHello();
        WorkStatus();
        MethodToBeOverriden();
    }

    // ! Method Overriding from the Base Class
    public override void MethodToBeOverriden(){
        Console.WriteLine("The method from the base class has been overriden by this.");
    }
}


// ! Multiple Inheritance - a subclass that inherits from another subclass
public class CriminalLawyer : Lawyer{
    private int numberOfCases, casesWon;

    public int CasesNumber{
        get { return numberOfCases; }
        set { numberOfCases = value; }
    }

    public int CasesWon{
        get { return casesWon; }
        set { casesWon = value; }
    }

    private void CareerSummary(){
        Console.WriteLine($"My total number of cases is {this.numberOfCases} and I won {this.casesWon} of them.");
    }

    public CriminalLawyer(string name, int age, int careerDuration, bool governmental, int numberOfCases, int casesWon) : base(name, age, careerDuration, governmental){
        this.numberOfCases = numberOfCases;
        this.casesWon = casesWon;
        
        WorkStatus();
        CareerSummary();
    }
}


// ! Polymorphism - two or more derived classes inherits from the same base class
public class Doctor : Persona{
    
    public Doctor(string name, int age) : base(name, age){
        SayHello();
        SomeProtectedMethod();
        MethodToBeOverriden();
    }

    // ! Method Overriding 
    public override void MethodToBeOverriden(){
        Console.WriteLine("The method from the base class has been overriden by this.");
    }
}


