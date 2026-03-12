

class ScriptureReference
{
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public ScriptureReference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public ScriptureReference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        if(_endVerse == 0)
        {
            return $"{_bookName} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_bookName} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}