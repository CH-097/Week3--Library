namespace Library
{
    class Book
    {
        private string title;   //field
        private string author;   //field
        private string isbn;     //field



        //title property to allow access to the private field
        public string Title
        {
            get { return title; }    //get method, returns value of the variable title
            set { title = value; }    //set method, assings a value to the title variable
        }

        public string Author
        {
            get { return author; }
            set 
            {
                //check if any character in incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {
                //check that incoming string is not blank
                if (value != "")
                {
                    isbn = value;
                } 
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }


        //constructor to add a new book
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }


        //method to display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }


    }
}