namespace c__Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            string title = "Refactoring";
            switch (title)
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
            #region Question 04
            //Using the same books array, use a while loop to print every book title. 
            string[] books2 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }
            #endregion
            #region Question 05
            //Write a do-while loop that prints "Checking book..." exactly 3 times.
            int count = 0;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);
            #endregion
            #region Question 06
            //Using the same books array, use a foreach loop to print every book title. 
            string[] books3 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books3)
            {
                Console.WriteLine(book);
            }
            #endregion
            #region Question 07
            //Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring". 
            string[] books4 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books4)
            {
                Console.WriteLine(book);
                if (book == "Refactoring")
                {
                    break;
                }
            }
            #endregion


        }
    }
}
