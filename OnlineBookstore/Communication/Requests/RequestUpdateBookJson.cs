using System.Reflection;

namespace OnlineBookstore.Communication.Requests;

public class RequestUpdateBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;  
    public decimal Price { get; set; }
}
