class Helper
{
    public string[] documents = new string[] {"book-of-mormon",
        "doctrine-and-covenants", "new-testament", "old-testament", "pearl-of-great-price"};
    
    public static List<int> IntListBetweenTwoNumbers(int start, int end)
    {
        List<int> list = new List<int>();

        for (int i = start; i < end; i++)
        {
            list.Add(i);
        }
        
        return list;
    }
}