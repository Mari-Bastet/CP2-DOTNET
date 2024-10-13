using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        FornecedorEntity? DeletarDados(int id);
        FornecedorEntity? EditarDados(int id, IFornecedorDto entity);
        FornecedorEntity? ObterPorId(int id);
        IEnumerable<FornecedorEntity> ObterTodos();
        FornecedorEntity? SalvarDados(IFornecedorDto entity);

    }
}
