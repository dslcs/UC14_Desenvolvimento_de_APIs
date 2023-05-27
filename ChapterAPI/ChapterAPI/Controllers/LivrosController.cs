using ChapterAPI.Models;
using ChapterAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        public readonly LivroRepository _livroRepository;
        public LivrosController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_livroRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            return Ok(_livroRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Livro novoLivro)
        {
            _livroRepository.Cadastrar(novoLivro);
            return StatusCode(201); //Created - Algo foi criado
        }
    }
}
