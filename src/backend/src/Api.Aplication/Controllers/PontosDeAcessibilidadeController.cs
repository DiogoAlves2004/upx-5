

using System.Net;
using Infra.UPX4.Domain.Dto;
using Infra.UPX4.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Api.UPX4.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PontosDeAcessibilidadeController : ControllerBase
    {
        private readonly IProdutoService _pontoService;


        public PontosDeAcessibilidadeController(IProdutoService pontoService)
        {
            _pontoService = pontoService;
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Salvar([FromBody] ProdutoDto pontodeacessibilidade)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                var result = await _pontoService.Salvar(pontodeacessibilidade);


                return Ok(result);



            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        
     
    
    }
}