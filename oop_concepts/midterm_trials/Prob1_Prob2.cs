using System;

// ! OOP Practices: 8 Items

public class EntryPoint {

    // public static void Main(string[] args) {
    //     Item2();
    // }

    public static void Item1(){
        int total = 3;
        Person[] persons = new Person[total];
        string currentName = " ";

        // for(int i = 0; i < total; i++){
        //     Console.Write($"Name {i+1}: ");
        //     currentName = Console.ReadLine();
        //     persons[i] = new Person(){
        //         Name = currentName
        //     };
        // }

        for(int i = 0; i < total; i++){
            Console.WriteLine(persons[i].ToString());;
        }

    }


    public static void Item2(){
        int total = 3;
        Person[] persons = new Person[total];

        for(int i = 0; i < total; i++){
            Console.Write($"Name {i+1}: ");
            persons[i] = new Person(Console.ReadLine());
        }
    
        for(int i = 0; i < total; i++){
            Console.WriteLine(persons[i].ToString());
        }
    
    }
}

public class Person {
   public string Name{get; set;}

   public Person(string name){
    Name = name;
   }

    public override string ToString(){
        return "Hello! My name is " + Name;
    }


    ~Person(){
        Name = string.Empty;
    }

}
