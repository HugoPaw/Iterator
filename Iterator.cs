var books = new WordsCollection();
books.AddItem("Harry Potter");
books.AddItem("Lord of the Rings");
books.AddItem("Eragon");

// Vorwärts
foreach (var book in books)
    Console.WriteLine(book);

// Jetzt rückwärts
books.ReverseDirection();

foreach (var book in books)
    Console.WriteLine(book);
