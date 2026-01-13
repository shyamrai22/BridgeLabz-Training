using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.book_buddy
{
    class BookBuddyUtilityImpl : IBookBuddy
    {
        private string[] library =  {
                                        "Clean Code - Robert Martin",
                                        "Effective Java - Joshua Bloch",
                                        "The Pragmatic Programmer - Andrew Hunt",
                                        "Design Patterns - Erich Gamma",
                                        "Introduction to Algorithms - Thomas H. Cormen",
                                        "",
                                        "",
                                        "",
                                        "",
                                        "",
                                        ""
                                    };
        private int bookIndex = 5;

        public void AddBook(string title, string author)
        {
            if(bookIndex >= library.Length)
            {
                Console.WriteLine("Library is already full");
                return;
            }
            library[bookIndex++] = $"{title.Trim()} - {author.Trim()}";
        }

        public void SortBook()
        {
            for (int i = 0; i < bookIndex - 1; i++)
            {
                for (int j = 0; j < bookIndex - i - 1; j++)
                {
                    if (string.Compare(library[j], library[j + 1], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        string temp = library[j];
                        library[j] = library[j + 1];
                        library[j + 1] = temp;
                    }
                }
            }
        }

        public void SearchBookByAuthor(string inputAuthor)
        {
            foreach (string bookDetails in library)
            {
                string[] parts = bookDetails.Split('-');

                if (parts.Length < 2)
                {
                    continue;
                }

                string author = parts[1].Trim();

                if (author.ToLower().Contains(inputAuthor.ToLower()))
                {
                    Console.WriteLine(bookDetails);
                }
            }
        }

        public void DisplayBooks()
        {
            for (int i = 0; i < bookIndex; i++)
            {
                Console.WriteLine(library[i]);
            }
        }

    }
}
