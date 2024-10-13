using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using CP2.Domain.Interfaces.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CP2.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public VendedorEntity? DeletarDados(int id)
        {
            var vendedor = _context.Vendedor.Find(id);

            if (vendedor is not null)
            {
                _context.Vendedor.Remove(vendedor);
                _context.SaveChanges();

                return vendedor;
            }

            return null;

        }

        public VendedorEntity? EditarDados(int id, IVendedorDto entity)
        {
            var vendedor = _context.Vendedor.Find(id);

            if (vendedor is not null)
            {

                vendedor.Nome = entity.Nome;
                vendedor.Email = entity.Email;
                vendedor.Telefone = entity.Telefone;
                vendedor.DataNascimento = entity.DataNascimento;
                vendedor.Endereco = entity.Endereco;
                vendedor.DataContratacao = entity.DataContratacao;
                vendedor.ComissaoPercentual = entity.ComissaoPercentual;
                vendedor.MetaMensal = entity.MetaMensal;

                _context.Vendedor.Update(vendedor);
                _context.SaveChanges();

                return vendedor;
            }

            return null;
        }


        public VendedorEntity? ObterPorId(int id)
        {
            var vendedor = _context.Vendedor.Find(id);

            if (vendedor is not null) { 
                return vendedor;
            }

            return null; 
        }

    public IEnumerable<VendedorEntity> ObterTodos()
        {
            var vendedores = _context.Vendedor.ToList();

            return vendedores;

        }

        public VendedorEntity? SalvarDados(IVendedorDto entity)
        {
            var vendedor = new VendedorEntity
            {
            Nome = entity.Nome,
            Email = entity.Email,
            Telefone = entity.Telefone,
            DataNascimento = entity.DataNascimento,
            Endereco = entity.Endereco,
            DataContratacao = entity.DataContratacao,
            ComissaoPercentual = entity.ComissaoPercentual,
            MetaMensal = entity.MetaMensal

        };

            _context.Vendedor.Add(vendedor);
            _context.SaveChanges();

            return vendedor;



        }
    }
}
