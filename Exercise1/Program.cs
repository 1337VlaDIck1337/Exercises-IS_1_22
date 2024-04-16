using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            Engine eng = new Engine();
            FuelTank tank = new FuelTank(300);
            Console.WriteLine( "amount: " + tank.GetAmount() );
            tank.Fill(250);
            Console.WriteLine("amount: " + tank.GetAmount());
            tank.Fill(100);
            Console.WriteLine("amount: " + tank.GetAmount());
            Console.WriteLine();
            Console.WriteLine("capacity: " + tank.GetLevel());

            eng.Start();
            Console.WriteLine( "State: " + eng.GetState() );
            Thread.Sleep( 2000 );
            Console.WriteLine();

            eng.Stop();
            Console.WriteLine( "State: " + eng.GetState() );

            Console.ReadKey();
        }
    }
}
