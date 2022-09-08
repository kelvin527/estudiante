using AutoMapper;
using Estudiante_Business.Interface;
using Estudiante_Data.Context;
using Estudiante_Data.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Estudiante_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        public readonly IDocenteService service;
        public DocenteController(IDocenteService service, BaseContext context, IMapper mapper1)
        {
            this.service = service;
        }

       
    }
}
