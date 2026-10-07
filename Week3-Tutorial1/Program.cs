/*
 * Week 3 tutorial
*/ 



// create new Book object called 'book'
// this object represents a copy of hte Book class, its the
// new book instance

using Library;

Book book = new Book();

// enter book information to the book object
book.Title = "C# for Beginners";
book.Author = "BillGates";
book.ISBN = "12345678";

//call method
book.DisplayInfo();


// another book object in our library
// object must have unique name
Book book1 = new Book();
book1.Title = "C# Methods and classes";
book1.Author = "Microsoft";
book1.ISBN = "55667778";

book1.DisplayInfo();