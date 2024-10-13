using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;


namespace CP2.Domain.Interfaces
{
    public interface IVendedorApplicationService
    {
        VendedorEntity? DeletarDadosVendedor(int id);
        VendedorEntity? EditarDadosVendedor(int id, IVendedorDto entity);
        IEnumerable<VendedorEntity> ObterTodosVendedores();
        VendedorEntity? ObterVendedorPorId(int id);
        VendedorEntity? SalvarDadosVendedor(IVendedorDto entity);
    }
}
