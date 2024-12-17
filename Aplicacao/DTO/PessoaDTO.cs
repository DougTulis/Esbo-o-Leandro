namespace Locacao.Aplicacao.DTO
{
    public class PessoaDTO
    {
        public PessoaDTO(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}