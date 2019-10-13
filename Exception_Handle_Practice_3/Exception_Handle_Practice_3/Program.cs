using System;


namespace Exception_Handle_Practice_3
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("\n Hello and Welcome! Please tell me your age to enter the park.. \n"); //1. Ask the user for his age.

                int age = Convert.ToInt32(Console.ReadLine());
                int yearBorn = 2019 - age;
                if (age < 1)
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("That means the year you were born is.. " + yearBorn + "."); //2. Display the year user born.

            }
            catch (ArgumentException) //3. Exceptions must be handled using "try .. catch". 
            {

                Console.WriteLine("Your age must be a number."); //4. Display appropriate error messages if user enters zero or negative numbers.

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex); //5. Display a general message if exception caused by anything else.

            }
            Console.WriteLine("Welcome to the Amusement Park!");
            Console.WriteLine("Thank you for viewing my program. Have a good day.");
            Console.ReadLine();
        }
    }
}