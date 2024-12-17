using Locacao.Aplicacao.DTO;
using Locacao.Aplicacao.Interface;
using Locacao.Infra.Repositorio;

namespace Locacao.Aplicacao.UseCase
{
    public class PessoaCriarUseCase
    {   
        private readonly IConnection _connection;
        private IPessoa _pessoa;

        public PessoaCriarUseCase(IConnection connection)
        {
            _connection = connection;
        }

        public void Execute(PessoaDTO input) 
        {  
            _pessoa = new PessoaRepositorio();

            _connection.Open();
            _pessoa.Adicionar(input);
            _connection.Close();
        }
    }
}