using CP2.Application.Dtos;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CP2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorApplicationService _applicationService;

        public FornecedorController(IFornecedorApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        /// <summary>
        /// Método para obter todos os dados do Fornecedor
        /// </summary>
        /// <returns>Fornecedor</returns>
        /// <response code="400">Não foi possivel obter os dados</response>
        [HttpGet]
        [Produces<IEnumerable<FornecedorEntity>>]
        public IActionResult Get()
        {
            var objModel = _applicationService.ObterTodosFornecedores();

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        /// Retorna os dados do fornecedor por Id
        /// </summary>
        /// <returns>Fornecedor</returns>
        /// <response code="400">Não foi possivel obter os dados</response>
        [HttpGet("{id}")]
        [Produces<FornecedorEntity>]
        public IActionResult GetPorId(int id)
        {
            var objModel = _applicationService.ObterFornecedorPorId(id);

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possivel obter os dados");
        }


        /// <summary>
        /// Insere dados do Fornecedor
        /// </summary>
        /// <returns>Fornecedor</returns>
        /// <response code="400">Não foi possivel salvar os dados</response>
        [HttpPost]
        [Produces<FornecedorEntity>]
        public IActionResult Post([FromBody] FornecedorDto entity)
        {
            try
            {
                var objModel = _applicationService.SalvarDadosFornecedor(entity);

                if (objModel is not null)
                    return Ok(objModel);

                return BadRequest("Não foi possivel salvar os dados");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        /// <summary>
        /// Atualiza dados do fornecedor
        /// </summary>
        /// <returns>Fornecedor</returns>
        /// <response code="400">Não foi possivel salvar os dados</response>
        [HttpPut("{id}")]
        [Produces<FornecedorEntity>]
        public IActionResult Put(int id, [FromBody] FornecedorDto entity)
        {
            try
            {
                var objModel = _applicationService.EditarDadosFornecedor(id, entity);

                if (objModel is not null)
                    return Ok(objModel);

                return BadRequest("Não foi possivel salvar os dados");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        /// <summary>
        /// Deleta o registro do fornecedor
        /// </summary>
        /// <returns>Fornecedor</returns>
        /// <response code="400">Não foi possivel deletar os dados</response>
        [HttpDelete("{id}")]
        [Produces<FornecedorEntity>]
        public IActionResult Delete(int id)
        {
            var objModel = _applicationService.DeletarDadosFornecedor(id);

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possivel deletar os dados");
        }
    }
}
