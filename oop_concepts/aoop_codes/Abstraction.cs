
namespace oop_concepts.aoop_codes{
    public abstract class Animal{ // can contain concrete and abstract classes
        public abstract void MakeSound();

        public static void Sleep(){
            Console.WriteLine("The animal is sleeping.");
        }
    }


    public class Dog : Animal{
        public override void MakeSound(){
            Console.WriteLine("Woof woof woof..");
        }
    }
}

