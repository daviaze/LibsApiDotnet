using EstudosApi.Dtos;
using EstudosApi.Errors;
using EstudosApi.Services;
using EstudosApi.Services.Interfaces;
using EstudosApi.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace EstudosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicoController : ControllerBase
    {
        private IValidator<MedicoDTO> _validator;
        //Injetando varias implementações de IService usando o Scrutor
        private readonly IEnumerable<IService> _services;
        private readonly IMedicoService _medicoService;

        public MedicoController(IValidator<MedicoDTO> validator, IEnumerable<IService> services, IMedicoService medicoService)
        {
            _validator = validator;
            _services = services;
            _medicoService = medicoService;
        }

        [HttpPost]
        public IActionResult PostMedico([FromBody] MedicoDTO medico)
        {
            _services.FirstOrDefault(x => x is MedicoService)!.Start();

            var validationResult = _validator.Validate(medico);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            return Ok(validationResult);
        }

        [HttpGet]
        public IActionResult GetMedico()
        {
            var result = _medicoService.Atender();

            //Usando o match do OneOf
            return result.Match<IActionResult>(
                success => Ok(success),
                error => {
                    if (error is GenericError)
                    {
                        return BadRequest(error);
                    }
                    return BadRequest(error);
                }
            );
        }
    }
}
