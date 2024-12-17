using Locacao.Aplicacao.DTO;

namespace Locacao.Aplicacao.Interface
{
    public interface IPessoa
    {
        public IEnumerable<PessoaDTO> Listar();
        public void Adicionar(PessoaDTO pessoa);
        public void Alterar(PessoaDTO pessoa);
        public void Excluir(PessoaDTO pessoa);
    }
}