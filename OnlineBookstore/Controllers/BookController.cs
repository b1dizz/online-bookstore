using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Communication.Requests;
using OnlineBookstore.Communication.Responses;

namespace OnlineBookstore.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpGet] //Retornar todos os livros que foram criados.
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id) //Buscar por ID.
    {
        var response = new Book
        {
            Author = "Nome do autor",
            Gender = "Genero do livro",
            Title = "Titulo do livro",
            Id = 1,           
            QuantityInStock = 1,
            Price = 10.00M         
        };
        
        return Ok(response);
    }

    [HttpPost] //Criar um novo livro.
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult CreateBooks([FromBody] RequestRegisterBookJson request) //Solicitação para criação do livro.
    {
        var response = new ResponseRegisterBookJson //Resposta criação do livro.
        {
            Id = 1,
            Title = request.Title
        };


        return Created(string.Empty, response);
    }

    [HttpPut] //Atualizar informações.
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateBookJson request)
    {
        
        return NoContent();
    }

    [HttpDelete] //Deletar informações.
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }


}
