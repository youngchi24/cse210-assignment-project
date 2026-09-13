public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry(string date, string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }
}