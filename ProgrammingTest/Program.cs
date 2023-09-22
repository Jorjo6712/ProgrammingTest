using ProgrammingTest.Controller;

namespace ProgrammingTest 
{ 
    /// <summary>
    /// This is the main program entrypoint
    /// </summary>
   internal class Program
   {
        static void Main(string[] args) 
        {
            Controller.Controller controller = new Controller.Controller();
            controller.MainController();
        }
   }
}