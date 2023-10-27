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
Console.WriteLine($"All Books With Status?  {queries.AllBookdWithStatus()}");

//Any book published in 2005
Console.WriteLine($"Any Book published in 2005?  {queries.AnyBookpublishedon2005()}");


//Python Books
//PrintCollection(queries.PythonBooks());

//Java Books Ordered by Name
//PrintCollection(queries.JavaBooksOrderedByName());

//Books with More tha 450 Pages ordered dsc
//PrintCollection(queries.BooksWithMoreThan450PagesDecscending());


//Firs three mos recent Java books
//PrintCollection(queries.FristTheeJavaBooksOrederedByDate()); 

//Third and Fourh book with over 400 pages
PrintCollection(queries.ThirdandAndFourthBookOver400Pages());

void PrintCollection(IEnumerable<Book> booksList)
{
    Console.WriteLine("{0,-60} {1,15} {2,15}\n", "Title", "Pages", "Publishing date");
    foreach(var item in booksList)
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
