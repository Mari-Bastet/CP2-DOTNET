using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        VendedorEntity? DeletarDados(int id);
        VendedorEntity? EditarDados(int id, IVendedorDto entity);
        VendedorEntity? ObterPorId(int id);
        IEnumerable<VendedorEntity> ObterTodos();
        VendedorEntity? SalvarDados(IVendedorDto entity);
    }
}
