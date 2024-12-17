using Locacao.Aplicacao.DTO;
using Locacao.Aplicacao.Interface;
using Locacao.Dominio.Model;

namespace Locacao.Infra.Repositorio
{
    public class PessoaRepositorio : IPessoa
    {
        public void Adicionar(PessoaDTO pessoa)
        {
            //aqui vai toda a sua logica de persistir essa pessoa dentro do banco de dados
        }

        public void Alterar(PessoaDTO pessoa)
        {
            throw new NotImplementedException();
        }

        public void Excluir(PessoaDTO pessoa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaDTO> Listar()
        {
            throw new NotImplementedException();
        }
    }
}