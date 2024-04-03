


internal class EntryPoint4{
    // public static void Main(string[] args){
    //     Car car1 = new Car(0);

    //     Console.Write("Gas to refuel: ");
    //     int gasToRefuel = int.Parse(Console.ReadLine());
        
    //     if (car1.Refuel(gasToRefuel)){
    //         car1.Drive();
    //     }
    // }
}


public interface IVehiculo{
    void Drive();
    bool Refuel(int amountToRefuel);
}

class Car : IVehiculo{

    private int StartingGas;
    public Car(int startingGas){
        startingGas = startingGas;
    }

    public void Drive(){
        if(StartingGas > 0){
            Console.WriteLine("The car is driving...");
        }
    }

    public bool Refuel(int amountToRefuel){
        StartingGas = amountToRefuel;
        return true;
    }

}