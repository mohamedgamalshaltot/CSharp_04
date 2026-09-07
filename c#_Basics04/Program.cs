using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            #region Question 08
           // Using the same books array, print every title except "The Pragmatic Programmer"(skip it with continue, don't stop the loop).
           string[] books5 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books5)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }
            #endregion
            #region Question 09
            //Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty, use return to exit the method early instead of printing anything.
            void PrintFirstBook(string[] books)
            {
                if (books == null ||books.Length == 0)
                {
                    return;
                }
                Console.WriteLine(books[0]);
            }
            #endregion
            #region (String Questions) Question 01

            // 1 - Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print both title and upperTitle to show that title did not change.
            string title2 = "clean code";
            string uppertitle = title2.ToUpper();
            Console.WriteLine($"title: {title2}");
            Console.WriteLine($"upperTitle: {uppertitle}");
            #endregion
            #region  (String Questions) Question 02
            //2 - Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals() to check if they point to the same object in memory.
            string title3 = "Clean Code";
            string title4= "Clean Code";
            Console.WriteLine(object.ReferenceEquals(title3, title4));
            #endregion
            #region (String Questions) Question 03
            //3-Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object. Print the final result. 
            StringBuilder sb = new StringBuilder("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb.ToString());
            #endregion
            #region (String Questions) Question 04
            //4-Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.
            StringBuilder sb1 = new StringBuilder("Book List");
         
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());

            #endregion


        }
    }
}
