using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.book_buddy
{
    interface IBookBuddy
    {
        void AddBook(string title, string author);

        void SortBook();

        void SearchBookByAuthor(string inputAuthor);

        void DisplayBooks(); 
    }
}
