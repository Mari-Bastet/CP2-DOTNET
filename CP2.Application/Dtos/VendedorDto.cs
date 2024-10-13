using CP2.Domain.Interfaces.Dtos;
using FluentValidation;

namespace CP2.Application.Dtos
{
    public class VendedorDto : IVendedorDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public DateTime DataContratacao { get; set; }
        public decimal ComissaoPercentual { get; set; }
        public decimal MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; }

        public void Validate()
        {
            var validateResult = new VendedorDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class VendedorDtoValidation : AbstractValidator<VendedorDto>
    {
        public VendedorDtoValidation()
        {
            RuleFor(x => x.Nome)
               .NotEmpty().WithMessage("Nome é obrigatório.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email é obrigatório.");

            RuleFor(x => x.Telefone)
                .NotEmpty().WithMessage("Telefone é obrigatório.");

            RuleFor(x => x.DataNascimento)
                .NotEmpty().WithMessage("Data de nascimento é obrigatória.");

            RuleFor(x => x.Endereco)
                .NotEmpty().WithMessage("Endereço é obrigatório.");

            RuleFor(x => x.DataContratacao)
                .NotEmpty().WithMessage("Data de contratação é obrigatória.");

            RuleFor(x => x.ComissaoPercentual)
                .InclusiveBetween(0, 100).WithMessage("Comissão percentual deve estar entre 0 e 100.");

            RuleFor(x => x.MetaMensal)
                .GreaterThan(0).WithMessage("Meta mensal deve ser maior que zero.");

        }
    }
}
