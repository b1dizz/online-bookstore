namespace OnlineBookstore.Communication.Requests;

public class RequestRegisterBookJson //Criar um livro
{
    public string Title { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public decimal Price { get; set; }
    

}
