using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c__Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 01
            //given string title = "refactoring";, write a switch statement that prints "great choice!" if the title is "clean code", "nice pick!" if it's "refactoring", and "never heard of it" for anything else.
            string title = "refactoring";
            switch (title)
            {
                case "clean code":
                    Console.WriteLine("great choice!");
                    break;
                case "refactoring":
                    Console.WriteLine("nice pick!");
                    break;
                default:
                    Console.WriteLine("never heard of it");
                    break;
            }
            #endregion
            #region question 02
            //given int pages = 464;, use the ternary operator to store "long book" or "short book" into a variable sizelabel (same rule as question 8: long if pages > 300). 
            int pages = 464;
            string sizelabel = pages > 300 ? "long book" : "short book";
            #endregion
            #region question 03
            //given string[] books = { "clean code", "the pragmatic programmer", "refactoring" };, use a for loop to print each book with its position number, like 1. clean code.
            string[] books = { "clean code", "the pragmatic programmer", "refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion
            #region question 04
            //using the same books array, use a while loop to print every book title. 
            string[] books2 = { "clean code", "the pragmatic programmer", "refactoring" };
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }
            #endregion
            #region question 05
            //write a do-while loop that prints "checking book..." exactly 3 times.
            int count = 0;
            do
            {
                Console.WriteLine("checking book...");
                count++;
            } while (count < 3);
            #endregion
            #region question 06
            //using the same books array, use a foreach loop to print every book title. 
            string[] books3 = { "clean code", "the pragmatic programmer", "refactoring" };
            foreach (string book in books3)
            {
                Console.WriteLine(book);
            }
            #endregion
            #region question 07
            //using the same books array, loop through it and print each title, but stop completely (break) once you reach "refactoring". 
            string[] books4 = { "clean code", "the pragmatic programmer", "refactoring" };
            foreach (string book in books4)
            {
                Console.WriteLine(book);
                if (book == "refactoring")
                {
                    break;
                }
            }
            #endregion
            #region question 08
            // using the same books array, print every title except "the pragmatic programmer"(skip it with continue, don't stop the loop).
            string[] books5 = { "clean code", "the pragmatic programmer", "refactoring" };
            foreach (string book in books5)
            {
                if (book == "the pragmatic programmer")
                {
                    continue;
                }
                        Console.WriteLine(book);
            }
            #endregion
            #region question 09
            //write a method printfirstbook() that prints the first book in the books array. if the array is empty, use return to exit the method early instead of printing anything.
            void printfirstbook(string[] books)
            {
                if (books == null || books.Length == 0)
                {
                    return;
                }
                    Console.WriteLine(books[0]);
            }
            #endregion
            #region (string questions) question 01

            // 1 - declare string title = "clean code";. call title.toupper() and store it in a new variable uppertitle.print both title and uppertitle to show that title did not change.
             string title2 = "clean code";
             string uppertitle = title2.ToUpper();
             Console.WriteLine($"title: {title2}");
             Console.WriteLine    ($"uppertitle: {uppertitle}");
            #endregion
            #region  (string questions) question 02
            //2 - declare two separate string variables, both set to the literal "clean code".use referenceequals() to check if they point to the same object in memory.
            string title3 = "clean code";
            string title4 = "clean code";
            Console.WriteLine(object.ReferenceEquals   (title3, title4));
            #endregion
            #region (string questions) question 03
            //3-create a stringbuilder, append() the text "book list", then append() " - updated" onto the same object. print the final result. 
                StringBuilder sb = new StringBuilder("book list");
            sb.Append(" - updated");
            Console.WriteLine(sb.ToString());
            #endregion
            #region (string questions) question 04
            //4-using the stringbuilder from the question above, use replace() to change "book list" into "library". print the result.
            StringBuilder sb1 = new StringBuilder("book list");

                sb.Replace("book list", "library");
            Console.WriteLine(sb.ToString());

            #endregion

            #region  (String Questions) Question 06
            //6-Build the same sentence as above, but using string interpolation ($"...").
            string title5 = "Clean Code";
            int pages5 = 464;
            string sentence = $"Book: {title5}, Pages: {pages5}";
            Console.WriteLine(sentence);
            #endregion
            #region (String Questions) Question 07
            //7-Build the same sentence again, but using string.Format(). 
            string title6 = "Clean Code";
            int pages6 = 464;
            string result = string.Format("Book: {0}, Pages: {1}", title6, pages6);
            Console.WriteLine(result);
            #endregion
        }
    }
}
