class Word
{
    private string  _word;

    public Word(string word)
    {
        _word = word;
    }
    public bool IsHidden()
    {
        if(_word == "")
        {
            return true;
        }
        if (_word.Substring(0, 1) == "_")
        {
            return true;
        }
        return false;
    }

    public string Get()
    {
        return _word;
    }
    public void Hide()
    {
        string hiddenWord = "";
        for (int i = 0; i < _word.Length; i++)
        {
            hiddenWord +=  "_";
        }
        _word = hiddenWord;
    }
}