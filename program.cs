using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract classes= modifier that indicates missing components or incomplete implementation.
            
            Car car = new Car();
            Bicyle bicyle = new Bicyle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle();





            Console.ReadKey();

        }

    }
  
    abstract class Vehicle
    {
        public int speed = 0;

        public void go ()
        {
            Console.WriteLine("This vehicle is moving !");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicyle : Vehicle 
    {
        public int wheels = 2;
        int maxSpeed= 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;

    }




}







