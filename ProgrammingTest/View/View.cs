namespace ProgrammingTest.View
{
    /// <summary>
    /// Used for displaying information to the user and letting them step through the program
    /// </summary>
    internal class View
    {
        internal void Text(string text)
        {
            Console.WriteLine(text);
        }

        internal void RL()
        {
            Console.ReadLine();
        }
    }
}
