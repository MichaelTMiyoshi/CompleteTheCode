/*
 * Add C# code to do some math.
 * 
 * This is the start of program to find the number of busses and vans
 * for a charter company.  You are going to calculate the number of 
 * busses and vans necessary for charter trip.  The busses will be 
 * completely full before vans are used.  If a bus will not be completely
 * filled, vans will be used.
 * 
 * The capacity of a bus is 60 people and the capacity of a van is 7.
 * 
 * The code is started with a greeting and a request for inputs.  Write
 * the rest of the code.
 */
namespace _03MathBusses
{
    internal class _03MathBusses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to THE CHARTER COMPANY");
            Console.Write("How many people are going? ");
            int people = Convert.ToInt32(Console.ReadLine());
            int busses;     // figure out how to calculate.  Hint: use division
            int peopleLeft; // figure out how to calculate.  Hint: use modulus
            int vans;       // figure out how to calculate.  Hint: use division
            // remember to output the number of busses and vans.
        }
    }
}