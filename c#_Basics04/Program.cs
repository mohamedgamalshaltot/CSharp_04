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
            #region Question 02
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel (same rule as question 8: long if pages > 300). 
            int pages = 464;
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            #endregion
            #region Question 03
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1. Clean Code.
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion

        }
    }
}
