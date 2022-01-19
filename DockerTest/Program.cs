using System;
using System.Threading.Tasks;

namespace DockerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Task.Delay(2000).Wait();
                    Console.WriteLine("cos");
                }
                catch (Exception ex)
                {

                    throw;
                } 
            }
        }
    }
}
