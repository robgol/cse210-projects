class Scripture
{
    private string _reference, _scripture;

    public Scripture(){}

    public Scripture(string reference)
    {
        _reference = reference;
    }

    public void SetScripture()
    {
        string book = _reference.Split(" ", 2)[0];
        string chapter = _reference.Split(" ", 2)[1].Split(":")[0];
        int startVerse = Convert.ToInt32(_reference.Split(" ", 2)[1].Split(":")[1].Split("-")[0]);
        int endVerse = 0;
        
        if(_reference.Contains("-"))
        {
            endVerse = Convert.ToInt32(_reference.Split(" ", 2)[1].Split(":")[1].Split("-")[1]);
        }
        else
        {
            endVerse = startVerse;
        }

        Reference reference = new Reference(book, chapter, startVerse, endVerse);

        _scripture = reference.Verses();
        _reference = reference.GetReference();
        
    }

    public string GetScripture()
    {
        return _scripture;
    }

    public string GetReference()
    {
        return _reference;
    }

    public string[] SplitInWords()
    {
        string[] words = _scripture.Split(' ');
        return words;
    }

    public void Hide3Words()
    {
        var words = SplitInWords();
        int count = 0;

        Random random = new Random();

        bool hideWords = true;
        do
        {
            int wordPosition = random.Next(0, words.Length);
            Word word = new Word(words[wordPosition]);
            if (!word.IsHidden())
            {
                word.Hide();
                words[wordPosition] = word.Get();
                count++;
            }
             Rebuild(words);

            int shownWords = ShownWords(words);

            if(shownWords < 3)
                {hideWords = true;}
            else{if (count < 3)
                hideWords = true;
            else
                hideWords = false;
            }
            if (shownWords == 0)
                hideWords = false; 
        } while (hideWords);
        
    }

    private void Rebuild(string[] words)
    {
        string scripture = "";
        foreach (var word in words)
        {
            scripture += $"{word} ";
        }
        _scripture = scripture;
    }

    private int ShownWords(string[] words)
    {
        int count = 0;
        foreach (var item in words)
        {
            Word word = new Word(item);
            
            if(!word.IsHidden())
            count++;
        }
        return count;
    }

    public bool NoMoreToHide()
    {
        if(ShownWords(SplitInWords()) == 0)
            return true;
        return false;
    }



}