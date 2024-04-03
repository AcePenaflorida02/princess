// ! 3 Persons in PersonArray
// 2 student, 1 teacher

class EntryPoint3{
    // public static void Main(string[] args){
    //     int total = 3;
    //     Person3[] persons = new Person3[total];

    //     for(int i = 0; i < total; i++){
    //         if(i == 0){
    //             persons[i] = new Teacher3(Console.ReadLine());
    //         }else{
    //             persons[i] = new Student2(Console.ReadLine());
    //         }
    //     }

    //     for(int i = 0; i < total; i++){
    //         if(i == 0){
    //             ((Teacher)persons[i]).Explain();
    //         }else{
    //             ((Student2)persons[i]).Study();
    //         }
    //     }
    // }
}


class Person3{

    public string Name{get; set;}

    public Person3(string name){
        Name = name;
    }

    public override string ToString(){
        return $"Hi I am {Name}";
    }

    ~Person3(){
        Name = string.Empty;
    }


}


class Student2: Person3{

    public Student2(string name) : base(name){
        Name = name;
    }
    public void Study(){
        Console.WriteLine("I am studying.");
    }
}


class Teacher3 : Person3{

    public Teacher3(string name) : base(name){
        Name = name;
    }

    internal void Explain(){
        Console.WriteLine("The teacher is explaining..");
    }
}









