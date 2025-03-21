public class Scripture
{

    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden()) //tells if word is already hidden
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }

    }

    public string GetDisplayText()
    {
       List<string> displayWords = new List<string>();
       foreach (var word in _words)
       {
        displayWords.Add(word.GetDisplayText());
       }
       return _reference.GetDisplayText() + string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}