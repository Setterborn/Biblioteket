using Biblioteket.Books;
using System;

namespace Biblioteket
{
    public static class UserInterface
    {
        public static void OpenMenu(Library library)
        {
            Console.Clear();
            Console.WriteLine("----------Library----------\n\n" +
                "1 - Add book to library\n" +
                "2 - Browse books in library\n" +
                "3 - Exit library\n" +
                "4 - Add testbooks to library\n");

            if (int.TryParse(Console.ReadLine(), out var input))
            {
                switch (input)
                {
                    case 1:
                        try
                        {
                            var genre = RequestGenreFromUser();
                            var book = CreateBook(genre);
                            library.AddBook(book);
                            Console.WriteLine("Book successfully created!");
                        }
                        catch (NotSupportedException ex)
                        {
                            WrongInput(library, ex.Message);
                        }
                        Console.ReadLine();
                        OpenMenu(library);
                        break;
                    case 2:
                        library.LibraryMenu();
                        Console.ReadLine();
                        OpenMenu(library);
                        break;
                    case 3:
                        Environment.Exit(1);
                        break;
                    case 4:
                        library.AddBooks(Test.TestBooks());
                        OpenMenu(library);
                        break;
                    default:
                        WrongInput(library);
                        break;
                }
            }
            else
            {
                WrongInput(library);
            }
        }

        public static Genre RequestGenreFromUser()
        {
            Console.WriteLine("Type of book: \n" +
                    "1 - Science\n" +
                    "2 - Childrensbook\n" +
                    "3 - Entertainment\n" +
                    "4 - All");

            if (Enum.TryParse<Genre>(Console.ReadLine(), out var genre))
            {
                return genre;
            }

            return Genre.Unknown;
        }

        private static Book CreateBook(Genre genre)
        {
            switch (genre)
            {
                case Genre.Science:
                    return CreateScienceBook();
                case Genre.Children:
                    return CreateChildrensBook();
                case Genre.Entertainment:
                    return CreateEntertainmentBook();
                default:
                    throw new NotSupportedException("Not supported, try again.");
            }
        }

        private static ScienceBook CreateScienceBook() =>
            new ScienceBook(
                RequestTitleFromUser(),
                RequestAuthorFromUser(),
                RequestNumberOfPagesFromUser(),
                RequestSubjectFromUser(),
                RequestDifficultyFromUser());

        private static ChildrensBook CreateChildrensBook() =>
            new ChildrensBook(
                RequestTitleFromUser(),
                RequestAuthorFromUser(),
                RequestNumberOfPagesFromUser(),
                RequestAimedAtFromUser(),
                RequestImageBookFromUser());

        private static EntertainingBook CreateEntertainmentBook() =>
            new EntertainingBook(
                RequestTitleFromUser(),
                RequestAuthorFromUser(),
                RequestNumberOfPagesFromUser(),
                RequestTypeFromUser(),
                RequestRomanAnthologyFromUser());

        private static string RequestRomanAnthologyFromUser()
        {
            Console.WriteLine("Roman or anthology?");
            return Console.ReadLine();
        }

        private static string RequestTypeFromUser()
        {
            Console.WriteLine("Type: ");
            return Console.ReadLine();
        }

        private static bool RequestImageBookFromUser()
        {
            Console.WriteLine("Imagebook? Y/N");

            if (char.TryParse(Console.ReadLine().ToLower(), out var imagebook))
            {
                return imagebook == 'y';
            }

            Console.WriteLine("Not supported, try again.");
            RequestImageBookFromUser();
            return default;
        }

        private static string RequestAimedAtFromUser()
        {
            Console.WriteLine("Children or youth?");
            return Console.ReadLine();
        }

        private static string RequestDifficultyFromUser()
        {
            Console.WriteLine("Difficulty: (1-3)");
            return Console.ReadLine();
        }

        private static string RequestAuthorFromUser()
        {
            Console.WriteLine("Author of book: ");
            return Console.ReadLine();
        }

        private static int RequestNumberOfPagesFromUser()
        {
            Console.WriteLine("Number of pages in book: ");
            
            if (int.TryParse(Console.ReadLine(), out var pages))
            {
                return pages;
            }

            Console.WriteLine("Not supported, try again.");
            RequestNumberOfPagesFromUser();
            return default;
        }

        private static string RequestSubjectFromUser()
        {
            Console.WriteLine("Subject: ");
            return Console.ReadLine();
        }

        private static string RequestTitleFromUser()
        {
            Console.WriteLine("Title of book: ");
            return Console.ReadLine();
        }

        public static void WrongInput(Library library, string errorMessage = "Wrong input!")
        {
            Console.WriteLine(errorMessage);
            Console.ReadLine();
            OpenMenu(library);
        }
    }
}
