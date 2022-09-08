using AutoMapper;
using Estudiante_Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace Estudiante_Api.Controllers
{
    public class BaseController : ControllerBase
    {
        public readonly BaseContext _context;
        public readonly IMapper _mapper;
        public BaseController(BaseContext context , IMapper mapper)
        {
           _context = context;
           _mapper = mapper;
        }
    }
}
