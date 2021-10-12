using Biblioteket.Books;
using System;
using System.Collections.Generic;

namespace Biblioteket
{
    public class Library
    {
        private List<Book> BookList = new();
        internal void LibraryMenu()
        {
            var genre = UserInterface.RequestGenreFromUser();
            switch (genre)
            {
                case Genre.Science:
                    PrintOutScienceBook();
                    break;
                case Genre.Children:
                    PrintOutChildrensBook();
                    break;
                case Genre.Entertainment:
                    PrintOutEntertainingBook();
                    break;
                case Genre.All:
                    PrintOutScienceBook();
                    PrintOutChildrensBook();
                    PrintOutEntertainingBook();
                    break;
                default:
                    Console.WriteLine("Not supported, try again.");
                    break;
            }
        }

        internal void AddBook(Book book)
        {
            BookList.Add(book);
        }

        internal void AddBooks(List<Book> books)
        {
            BookList.AddRange(books);
        }

        private void PrintOutEntertainingBook()
        {
            Console.WriteLine("----------Entertainment Books----------");
            foreach (Book b in BookList)
            {
                if (b is EntertainingBook)
                {
                    Console.WriteLine($"Title: {b.Title} |Author: {b.Author} |Pages: {b.Pages} " +
                        $"|Type: {((EntertainingBook)b).Type} " +
                        $"|Roman or anthology: {((EntertainingBook)b).RomanAnthology}");
                }
            }
        }

        private void PrintOutChildrensBook()
        {
            Console.WriteLine("----------Childrens Books----------");
            foreach (Book b in BookList)
            {
                if (b is ChildrensBook)
                {
                    Console.WriteLine($"Title: {b.Title} |Author: {b.Author} |Pages: {b.Pages} " +
                        $"|Aimed at: {((ChildrensBook)b).AimedAt} " +
                        $"|Is a imagebook: {((ChildrensBook)b).ImageBook}");
                }
            }
        }

        private void PrintOutScienceBook()
        {
            Console.WriteLine("----------Science Books----------");
            foreach (Book b in BookList)
            {
                if (b is ScienceBook)
                {
                    Console.WriteLine($"Title: {b.Title} |Author: {b.Author} |Pages: {b.Pages}" +
                        $"|Subject: {((ScienceBook)b).Subject} " +
                        $"|Difficulty: {((ScienceBook)b).Difficulty}");
                }
            }
        }
    }
}
