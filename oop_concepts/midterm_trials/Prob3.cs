



internal class EntryPoint2{
    
    // public static void Main(string[] args){
    //     Person2 person1 = new Person2();
    //     Student student1 = new Student();
    //     Teacher teacher1 = new Teacher();

    //     person1.Greet();

    //     student1.SetAge(21);
    //     student1.Greet();
    //     student1.ShowAge();
        
    //     teacher1.Greet();
    //     teacher1.SetAge(29);
    //     teacher1.Explain();
    // }
}


internal class Person2{
    protected int age;
    public void Greet(){
        Console.WriteLine("Hi Bitch...");
    }

    public void SetAge(int age){
        this.age = age;
    }

}

internal class Student: Person2{

    private void Study(){
        Console.WriteLine("Im studying...");
    }

    public void ShowAge(){
        Console.WriteLine($"My age is: {age} years old.");
    }

}

internal class Teacher: Person2{
    
    public void Explain(){
        Console.WriteLine("Im explaining...");
    }

    public static explicit operator Teacher(Person3 v)
    {
        throw new NotImplementedException();
    }
}
