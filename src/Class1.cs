using System;

namespace src
{
    public class Class1
    {
        public Class1()
        {
           var env = Environment.GetEnvironmentVariable("ENV");
            System.Console.Write($"Hello world, I am running on {env}!"); 
        }
    }
}
