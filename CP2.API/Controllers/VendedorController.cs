using CP2.Application.Dtos;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CP2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorApplicationService _applicationService;

        public VendedorController(IVendedorApplicationService applicationService)
        {
            _applicationService = applicationService;   
        }

        /// <summary>
        /// Método para obter todos os dados do Vendedor
        /// </summary>
        /// <returns>Lista de vendedores</returns>
        /// <response code="400">Não foi possivel obter os dados</response>
        [HttpGet]
        [Produces<IEnumerable<VendedorEntity>>]
        public IActionResult Get()
        {
            var objModel = _applicationService.ObterTodosVendedores();

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possivel obter os dados");
        }


        /// <summary>
        /// Retorna dados do vendedor por id
        /// </summary>
        /// <returns>Vendedor</returns>
        /// <response code="400">Não foi possivel obter os dados</response>
        [HttpGet("{id}")]
        [Produces<VendedorEntity>]
        public IActionResult GetPorId(int id)
        {
            var objModel = _applicationService.ObterVendedorPorId(id);

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possivel obter os dados");
        }

        /// <summary>
        /// Insere dados do vendedor
        /// </summary>
        /// <response code="400">Não foi possivel salvar os dados</response>
        [HttpPost]
        [Produces<VendedorEntity>]
        public IActionResult Post([FromBody] VendedorDto entity)
        {
            try
            {
                var objModel = _applicationService.SalvarDadosVendedor(entity);

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
        /// Atualiza dados do vendedor por Id
        /// </summary>
        /// <response code="400">Não foi possivel salvar os dados</response>
        [HttpPut("{id}")]
        [Produces<VendedorEntity>]
        public IActionResult Put(int id, [FromBody] VendedorDto entity)
        {
            try
            {
                var objModel = _applicationService.EditarDadosVendedor(id, entity);

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
        /// Deleta os dados do vendedor
        /// </summary>
        /// <response code="400">Não foi possivel deletar os dados</response>
        [HttpDelete("{id}")]
        [Produces<VendedorEntity>]
        public IActionResult Delete(int id)
        {
            var objModel = _applicationService.DeletarDadosVendedor(id);

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possivel deletar os dados");
        }
    }
}
