using Biblioteket.Books;
using System.Collections.Generic;

namespace Biblioteket
{
    class Test
    {
        internal static List<Book> TestBooks() =>
            new()
            {
                new ScienceBook("Wildlife in africa", "John Petersen", 125, "Animals", "1"),
                new ScienceBook("The ancient pyramids", "Jonathan Brown", 250, "History", "2"),
                new ScienceBook("Our planet", "Melanie Stephenson", 500, "Environment", "3"),
                new ChildrensBook("My little pony", "Mr Buttercups", 25, "Child", false),
                new ChildrensBook("Max pottie", "Mr Andersson", 12, "Child", true),
                new ChildrensBook("The little mermaid", "H.C Andersen", 75, "Youth", false),
                new EntertainingBook("Harry Potter", "J.K Rowling", 650, "Fantasy", "Roman"),
                new EntertainingBook("Fellowship of the ring", "J.R.R Tolkien", 1100, "Fantasy", "Roman"),
                new EntertainingBook("Romance in rome", "Andrea Buscatorre", 700, "Romance", "Anthology")
            };
    }
}
