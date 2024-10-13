using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorApplicationService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? DeletarDadosFornecedor(int id)
        {
            return _repository.DeletarDados(id);
        }

        public FornecedorEntity? EditarDadosFornecedor(int id, IFornecedorDto entity)
        {
            return _repository.EditarDados(id, entity);
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            return _repository.ObterTodos();
        }

        public FornecedorEntity? SalvarDadosFornecedor(IFornecedorDto entity)
        {
            return _repository.SalvarDados(entity);
        }

    }
}
