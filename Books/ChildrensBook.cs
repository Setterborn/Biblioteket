namespace Biblioteket.Books
{

    //----------Subclass Children----------
    class ChildrensBook : Book
    {
        //----------Properties----------
        internal string AimedAt { get; set; }
        internal bool ImageBook { get; set; }

        //----------Constructor----------
        internal ChildrensBook(string Title, string Author, int Pages, string AimedAt, bool ImageBook)
        {
            this.Title = Title;
            this.Author = Author;
            this.Pages = Pages;
            this.AimedAt = AimedAt;
            this.ImageBook = ImageBook;
        }
    }
}
