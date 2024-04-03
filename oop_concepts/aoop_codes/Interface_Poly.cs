using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oop_concepts.aoop_codes
{
    public interface IDrawable{
        void Draw();
    }

    public interface IResizable{
        void Resize(int length, int width);
    }

    public class Circle : IDrawable, IResizable{
        public void Draw(){
            Console.WriteLine("Drawing a circle..");
        }
    
        public void Resize(int length, int width){
            Console.WriteLine($"Resizing... Length: {length}.. Width: {width}");
        }
    }


    // ! Polymorphism
    public class Triangle : IDrawable{
        public void Draw(){
            Console.WriteLine("Drawing a triangle.");
        }
    }

    public class Square : IDrawable{
        public void Draw(){
            Console.WriteLine("Drawing a square.");
        }
    }
}