

namespace Library
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;


        //new method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }




    }
}
