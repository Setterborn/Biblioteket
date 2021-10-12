namespace Biblioteket.Books
{
    //----------Subclass Science----------
    class ScienceBook : Book
    {
        //----------Properties----------
        internal string Subject { get; set; }
        internal string Difficulty { get; set; }

        //----------Constructor----------
        internal ScienceBook(string Title, string Author, int Pages, string Subject, string Difficulty)
        {
            this.Title = Title;
            this.Author = Author;
            this.Pages = Pages;
            this.Subject = Subject;
            this.Difficulty = Difficulty;
        }
    }
}
