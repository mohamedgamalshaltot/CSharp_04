namespace c__Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            string title = "Refactoring";
            switch(title) 
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion
        }
    }
}
