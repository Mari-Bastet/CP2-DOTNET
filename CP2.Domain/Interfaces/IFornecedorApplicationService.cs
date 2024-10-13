using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorApplicationService
    {
        FornecedorEntity? DeletarDadosFornecedor(int id);
        FornecedorEntity? EditarDadosFornecedor(int id, IFornecedorDto entity);
        FornecedorEntity? ObterFornecedorPorId(int id);
        IEnumerable<FornecedorEntity> ObterTodosFornecedores();
        FornecedorEntity? SalvarDadosFornecedor(IFornecedorDto entity);
    }
}
