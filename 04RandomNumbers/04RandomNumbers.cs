/*
 * Add C# code to create and output some random numbers.
 * 
 * Create and output some random numbers.  Specifically:
 *      A pair of six-sided dice [1-6]
 *      A single 12-sided die [1-12]
 *      A random character between [a-z] or [A-Z]
 *      A random double between [0-5.0)
 *      
 * The square brackets mean([]) inclusive, that is that the number
 * on whichever side the bracket is a legal number.  The parentheses (())
 * mean that the number on that side is not included in the range.  It is
 * outside the largest (usually) value.
 */
namespace _04RandomNumbers
{
    internal class _04RandomNumbers
    {
        /* This is the first time we will be using objects outside Main().
         * Do not do this often.  We are creating a "global" object, which 
         * is generally not good programming practice.  It usually makes 
         * debugging more difficult, so we stay away from it, especially as 
         * beginners.  However, I think that this one object is better placed
         * here for when you use functions and even objects.  (You might even
         * place it one level outside when you get to objects.)
         */
        static Random rng;  // static means that any method can use it.
                            // We will get to methods later.
        static void Main(string[] args)
        {
            rng = new Random();     // Try putting an integer in the parentheses.
                                    // See what happens when you run it a few times.
            Console.WriteLine("Random Numbers!");
            int fun = rng.Next(50, 101);    // what is the range of numbers this could output?
            Console.WriteLine(fun);
        }
    }
}