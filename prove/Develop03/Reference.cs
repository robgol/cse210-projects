using System.Text.Json;
using System.Text.Json.Nodes;
class Reference
{
    private string _chapter, _book, _scripture;
    private int _startVerse, _endVerse;
    private static string[] _documents = new string[] {"book-of-mormon",
    "doctrine-and-covenants", "new-testament", "old-testament", "pearl-of-great-price"};

    public Reference(){}

    public Reference(string book, string chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = _startVerse;

    }

    public Reference(string book, string chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;

    }

    public void GetVerse(int referenceVerse )
    {
        string jsonString = File.ReadAllText($"{_documents[2]}.json");
        //JsonNode document = JsonNode.Parse(jsonString)!;
        using (JsonDocument document = JsonDocument.Parse(jsonString))
        {
            JsonElement root = document.RootElement;
            JsonElement books = root.GetProperty("books");

            foreach(JsonElement book in books.EnumerateArray())
            {
                book.TryGetProperty("book", out JsonElement bookName);

                if (bookName.GetString() == _book)
                {
                    FindChapter(book, referenceVerse);
                }
            }

        }  
    }

    private void FindChapter(JsonElement book, int verse)
    {
        book.TryGetProperty("chapters", out JsonElement chapters);

        foreach(var foundChapter in chapters.EnumerateArray())
        {
            foundChapter.TryGetProperty("chapter", out JsonElement singleChapter);
            if (singleChapter.GetInt32() == Convert.ToInt32(_chapter))
            {
                FindVerse(foundChapter, verse);
            }
        }
    }

    private void FindVerse(JsonElement foundChapter, int verse)
    {
        foundChapter.TryGetProperty("verses", out JsonElement verses);

        foreach (var foudVerse in verses.EnumerateArray())
        {
            string jsonString = foudVerse.ToString();
            JsonNode verseJson = JsonNode.Parse(jsonString)!;

            if ( ((int)verseJson!["verse"]) == verse)
            {
                _scripture = $"{verseJson!["text"]}";
            }

        }
    }

    public string Verses()
    {
        string scripture = "";
        if (_startVerse == _endVerse)
        {
            GetVerse(_startVerse);
            scripture = _scripture;
        }
        else
        {
            for (int i = _startVerse; i <= _endVerse; i++)
            {
                GetVerse(i);
                scripture = scripture + " " + _scripture;
            }
        }

        return scripture;
    }

    public string GetReference()
    {
        string reference = "";
        if (_startVerse == _endVerse)
        {
            reference = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return reference;
    }
}