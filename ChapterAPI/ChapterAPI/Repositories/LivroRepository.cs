using ChapterAPI.Context;
using ChapterAPI.Models;

namespace ChapterAPI.Repositories
{
    public class LivroRepository
    {
        public readonly ChapterContext _context;
        public LivroRepository(ChapterContext context) 
        { 
            _context= context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

        public Livro BuscarPorId(int id)
        {
            return _context.Livros.Find(id)!;
        }

        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }
    }
}
