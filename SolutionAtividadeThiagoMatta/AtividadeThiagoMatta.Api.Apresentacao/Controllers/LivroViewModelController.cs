using AtividadeThiagoMatta.Api.Apresentacao.ViewModels;
using AtividadeThiagoMatta.Aplicacao.Interface;
using AtividadeThiagoMatta.Dominio.Entities;
using AutoMapper;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AtividadeThiagoMatta.Api.Apresentacao.Controllers
{
    public class LivroViewModelController : ApiController
    {
        private readonly ILivroAppService _livroApp;


        public LivroViewModelController(ILivroAppService livroApp)
        {
            _livroApp = livroApp;
        }

        // GET: api/livro
        [ResponseType(typeof(IEnumerable<LivroViewModel>))]
        [Route("api/livro/listar")]
        public IHttpActionResult GetLivros()
        {
            var livros = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroViewModel>>(_livroApp.OrdenarPorNome(_livroApp.GetAll())); 
            if (livros == null)
                return NotFound();
           
            return Ok(livros);
        }

        // GET: api/livro/5
        [ResponseType(typeof(LivroViewModel))]
        [Route("api/livro/pesquisa/{id}")]
        public IHttpActionResult GetLivro(int id)
        {
            var livro = Mapper.Map<Livro,LivroViewModel>(_livroApp.GetById(id));
            if (livro == null)
            {
                return NotFound();
            }

            return Ok(livro);
        }

        // PUT: api/livro/1
        [ResponseType(typeof(void))]
        [Route("api/livro/alterar/{id}")]
        public IHttpActionResult PutLivro(int id, LivroViewModel livro)
        {
            if (livro == null)
                return BadRequest(ModelState);
            
            _livroApp.Update(Mapper.Map<LivroViewModel, Livro>(livro));

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/cidade
        [ResponseType(typeof(LivroViewModel))]
        [Route("api/livro/novo")]
        public IHttpActionResult PostLivro(LivroViewModel livro)
        {
            if (livro == null)
                return BadRequest(ModelState);

            _livroApp.Add(Mapper.Map<LivroViewModel,Livro>(livro));

            return Ok(livro);
        }

        // DELETE: api/livro/5
        [ResponseType(typeof(void))]
        [Route("api/livro/excluir/{id}")]
        public IHttpActionResult DeleteLivro(int id)
        {
            var livro = _livroApp.GetById(id);
            if (livro == null)
                return BadRequest(ModelState);
            
            _livroApp.Remove(livro);

            return Ok(livro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _livroApp.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
