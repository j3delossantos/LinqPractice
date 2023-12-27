// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Diagnostics.CodeAnalysis;

LinqQueries queries = new LinqQueries();

//PrintCollection(queries.FullCollection());

//Boks published after 2000
//PrintCollection(queries.After2000Collection());

//Books with more than 250 pages and has the word in action
//PrintCollection(queries.BooksWithMorethan250Pages());

// All Books With Status
//Console.WriteLine($"All Books With Status?  {queries.AllBookdWithStatus()}");

//Any book published in 2005
//Console.WriteLine($"Any Book published in 2005?  {queries.AnyBookpublishedon2005()}");


//Python Books
//PrintCollection(queries.PythonBooks());

//Java Books Ordered by Name
//PrintCollection(queries.JavaBooksOrderedByName());

//Books with More tha 450 Pages ordered dsc
//PrintCollection(queries.BooksWithMoreThan450PagesDecscending());


//Firs three mos recent Java books
//PrintCollection(queries.FristTheeJavaBooksOrederedByDate()); 

//Third and Fourh book with over 400 pages
//PrintCollection(queries.ThirdandAndFourthBookOver400Pages());


//First three books filtered with Select
//PrintCollection(queries.FirstThreeCollectionBooks());

//The amout of books between  200 and 500 pages
//Console.WriteLine($"The amout of books between  200 and 500 pages is: {queries.CountBooksBetween200and500()}");

//Min Date Realeased Book
//Console.WriteLine($"The earliest book was published in: {queries.MinDateRealeasedBook()}");

//Max number of pages on a book
//Console.WriteLine($"The Max number of pages on a book is: {queries.MaxNumberOfPagesBook()}");

//Book with min amout of pages
/*var BookMinPages = queries.BookWithMinAmounttOfPages();
Console.WriteLine($" The Book with min amout of pages is:{BookMinPages.Title} - With {BookMinPages.PageCount} Pages");
*/

//Most recent Book
/*var RecentBook = queries.MostRecentBook();
Console.WriteLine($" The mos recent Book is:{RecentBook.Title} - Published On:{RecentBook.PublishedDate.ToShortDateString()}");
*/

//Console.WriteLine(queries.SumBookPages());

//Console.WriteLine(queries.BookTitlesAfter2015());

///Console.WriteLine(queries.AverageCharactersOnBookTitles());

//PrintGroup(queries.BooksAfter200GroupedByYear()); 

//Book diccionary grouped by letter
/*var lookUpDiccionary =queries.BookByLeterDictionary();
PrintDiccionary(lookUpDiccionary, 'P');
*/

//Books filtered with Join
PrintCollection(queries.BooksAfter2005WithMoreThan500Pages());


void PrintCollection(IEnumerable<Book> booksList)
{
    Console.WriteLine("{0,-60} {1,15} {2,15}\n", "Title", "Pages", "Publishing date");
    foreach(var item in booksList)
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

void PrintGroup(IEnumerable<IGrouping<int, Book>> BookList)
{
    foreach(var group  in BookList)
    {
        Console.WriteLine("");
        Console.WriteLine($"Group: {group.Key}");
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Title", "# Pages", "Publishing Date");

        foreach(var item in group)
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
        }
    }
}

void PrintDiccionary(ILookup<char, Book> BookList, char leter)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Title", "# Pages", "Publishing Date");

        foreach(var item in BookList[leter])
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
        }
}
