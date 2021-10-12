namespace Biblioteket.Books
{
    //----------Subclass Entertainment----------
    class EntertainingBook : Book
    {
        //----------Properties----------
        internal string Type { get; set; }
        internal string RomanAnthology { get; set; }

        //----------Constructor----------
        internal EntertainingBook(string Title, string Author, int Pages, string Type, string RomanAnthology)
        {
            this.Title = Title;
            this.Author = Author;
            this.Pages = Pages;
            this.Type = Type;
            this.RomanAnthology = RomanAnthology;
        }
    }
}
