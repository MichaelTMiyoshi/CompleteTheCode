/*
 * Add C# code to make the console output at least 5 lines to the screen
 * (besides the two on the screen already).
 * 
 * Notes:   \n is a newline
 *          \t is a tab
 *          \\ is a backslash (\)
 *          \" is a double quote (")
 * 
 * If you want to get fancy, look up and use UNICODE characters.
 * (The character below is a Greek Omega (Ω)
 * 
 * By the way, the \ inside a double quote (string literal) starts what
 * is known as an ESCAPE sequence.  The four simple escape sequences 
 * above are just two characters.  The backslash (\) and whatever
 * character you are trying to output.  The unicode escape sequence
 * is a series of six characters - the backslash and u (\u) tell you 
 * that the next four characters are hexidecimal numbers corresponding
 * to unicode characters.  Note that not all unicode characters are 
 * printable.  If you get a question mark (?) instead of the character
 * you were expecting, you are trying to print an unprintable character
 * or you need to change the console font (which you will need to look
 * up how to do).
 * 
 * One last thing.  Make sure to know the difference between:
 *      Console.WriteLine();
 *      and
 *      Console.Write();
 */
namespace _01SayHello
{
    internal class _01SayHello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("\u03a9");
        }
    }
}