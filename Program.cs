using System;

namespace kopi
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMechine yummyCoffe = new CoffeMechine(coffe, water);
           

            
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            String result = yummyCoffe.Esspresso;
            Console.WriteLine("result" + result);

            
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.Esspresso;
            Console.WriteLine("result" + result);


            
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.Esspresso;
            Console.WriteLine("result" + result);


            
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.Esspresso;
            Console.WriteLine("result" + result);

            
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.Esspresso;
            Console.WriteLine("result" + result);

            

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.Esspresso;
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
        }
    }
}
