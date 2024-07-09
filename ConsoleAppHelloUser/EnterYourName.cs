using System;

namespace ConsoleAppHelloUser

{
    public class EnterYourName
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your username please: ");
            string? username = Console.ReadLine();

            HelloWorld helloWorld = new HelloWorld();
            string message = helloWorld.HelloMessage(username);

            Console.WriteLine(message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}