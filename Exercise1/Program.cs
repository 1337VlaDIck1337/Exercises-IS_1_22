using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            Engine eng = new();
            Console.WriteLine( "State: " + eng.GetState() );
            Console.WriteLine();

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
