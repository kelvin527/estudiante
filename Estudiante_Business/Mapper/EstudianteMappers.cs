using AutoMapper;
using Estudiante_Business.Dtos;
using Estudiante_Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Business.Mapper
{
    public class EstudianteMappers : Profile
    {
        public EstudianteMappers()
        {
            CreateMap<Estudiantes, EstudianteDto>().ReverseMap();
            CreateMap<Docentes, DocenteDto>().ReverseMap();
            CreateMap<Grados, GradoDto>().ReverseMap();
            CreateMap<Materias, MateriaDto>().ReverseMap();
            CreateMap<Periodos, PeriodoDto>().ReverseMap();
            CreateMap<Calificaciones, CalificacionesDto>().ReverseMap();




        }
    }
}
