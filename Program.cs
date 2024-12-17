// See https://aka.ms/new-console-template for more information
using Locacao.Aplicacao;
using Locacao.Aplicacao.DTO;
using Locacao.Aplicacao.Interface;
using Locacao.Aplicacao.UseCase;
using Locacao.Infra.Repositorio;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // var connection = new MySqlAdapterConnection();
        var connection = new PostgresAdapterConnection();

        var useCase = new PessoaCriarUseCase(connection);
        var pessoaDTO = new PessoaDTO(1, "Douglas");       
        useCase.Execute(pessoaDTO);
    }
}