namespace Locacao.Dominio.Model
{
    public abstract class AbstractModel
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}