using System;
//Using the Systen namespace, which is a part of the .Net Framework Class Library
//A namespace is a collection of classes

//Common Lanuage Runtime - the executuion environment that runs our application

namespace HelloWorld
{

    // Variable is declared by a type followed by an identifier and then a ;
    // Variables can't be used unless they are initialised - assigned a value;
    // use proper case for variables (naming convention called Camel Case);

    //Use Pascal Case for constants

    //Changing the file simply to see what happens in GIT

    class Program
    {
        static void Main(string[] args)
        {
            //Feeling tired

            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?");
            int hours = int.Parse(Console.ReadLine());
            
            if(hours < 8)
            { 
                Console.WriteLine("Hello, " + name + ". You must be tired!");
            }
            else
            {
                Console.WriteLine("Hello, " + name + ". vYou must feel well rested!");
            }
           
            
            
            /*int firstVariable = 1;
            var toArg = "Name 1";
            var inputOne = args[0];
            var inputTwo = args[1];

            Console.WriteLine(firstVariable + " " + inputOne + " " + inputTwo );

            var Person = new Person();
            Person.Name = "Phil";
            Person.Introduce(toArg);*/
        }
    }
    /*
    public class Person
    {
        public string Name;

        public void Introduce(string toArg)
        {
            Console.WriteLine("Hi {0}, my name is {1}", toArg, Name);
        }
    }*/

}
