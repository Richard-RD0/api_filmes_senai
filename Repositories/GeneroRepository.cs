using api_filmes_senai.Interfaces;
using API_filmes_senai.Context;
using API_filmes_senai.Domains;
using API_filmes_senai.Interfaces;

       
namespace api_filmes_senai.Repositories
    {
        public class GeneroRepository : IGeneroRepository
    {
            private readonly Filmes_Context _context;

            /// <summary>
            /// Construtor do repositorio
            /// Aqui, toda vez que o construtor for chamado, os dados do contexto estaram disponiveis
            /// </summary>
            /// <param name="contexto"></param>

            public GeneroRepository(Filmes_Context contexto)
            {
                _context = contexto;
            }

            public void Atualizar(Guid id, Genero genero)
            {
                throw new NotImplementedException();
            }

            public Genero BuscarPorId(Guid id)
            {
                throw new NotImplementedException();
            }

            public void Cadastrar(Genero novoGenero)
            {
            try
            {
                _context.Genero.Add(novoGenero);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            }

            public void Deletar(Guid id)
            {
                throw new NotImplementedException();
            }

            public List<Genero> Listar()
            {
                try
                {
                    List<Genero> listaGeneros = _context.Genero.ToList();

                    return listaGeneros;
                }
                catch (Exception)
                {

                    throw;
                }
            }

       
    }
    }


