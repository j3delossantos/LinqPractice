using System.Linq;

public class LinqQueries
{
    private List<Book> booksCollection = new List<Book>();

    public LinqQueries()
    {
        using(StreamReader reader = new StreamReader("books.json"))
        {
           string json = reader.ReadToEnd();
           this.booksCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() {PropertyNameCaseInsensitive = true}); 
        }
    }

    public IEnumerable<Book> FullCollection()
    {
        return booksCollection;
    }

     public IEnumerable<Book> After2000Collection()
    {
        //Estension Method
       // return booksCollection.Where(p=> p.PublishedDate.Year > 2000);


       //Using QUery Expresion
       return from x in booksCollection where x.PublishedDate.Year > 2000 select x;
    }

    public IEnumerable<Book> BooksWithMorethan250Pages()
    {
        //using extension method
        return booksCollection.Where(i=> i.PageCount > 250 && i.Title.Contains("in Action"));


  
        //Using QUery Expresion
        //return from x in booksCollection where x.PageCount > 250 && x.Title.Contains("in Action") select x;
    }

    public bool AllBookdWithStatus()
    {
        return booksCollection.All(p=> p.Status != string.Empty);
    }

    public bool AnyBookpublishedon2005()
    {
        return booksCollection.Any(p=> p.PublishedDate.Year == 2005);
    }

    public IEnumerable<Book> PythonBooks()
    {
        return booksCollection.Where(p=> p.Categories.Contains("Python"));
    }

    public IEnumerable<Book> JavaBooksOrderedByName()
    {
        return booksCollection.Where(p=> p.Categories.Contains("Java")).OrderBy(p=> p.Title);
    }

    public IEnumerable<Book> BooksWithMoreThan450PagesDecscending()
    {
        return booksCollection.Where(p=> p.PageCount > 450).OrderByDescending(p=> p.PageCount);
    }

    public IEnumerable<Book> FristTheeJavaBooksOrederedByDate()
    {
        return booksCollection
        .Where(i=> i.Categories.Contains("Java"))
        .OrderByDescending(i=> i.PublishedDate)
        .Take(3);
    }

     public IEnumerable<Book> ThirdandAndFourthBookOver400Pages()
     {
        return booksCollection
        .Where(i=> i.PageCount > 400)
        .OrderBy(i=> i.PageCount)
        .Take(4)
        .Skip(2);
     }
}