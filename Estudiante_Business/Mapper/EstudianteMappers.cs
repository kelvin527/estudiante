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
            CreateMap<Estudiantes, EstudianteDto>()
                 .ForMember(x => x.Grado, o => o.MapFrom(p => p.Grado.Descripcion)).ReverseMap();

            CreateMap<Docentes, DocenteDto>().ReverseMap();
            CreateMap<Grados, GradoDto>().ReverseMap();
            CreateMap<Materias, MateriaDto>().ReverseMap();
            CreateMap<Periodos, PeriodoDto>().ReverseMap();
            CreateMap<Calificaciones, CalificacionesDto>().ReverseMap();
            CreateMap<Calificaciones, CalificacionesDto>()
             .ForMember(x => x.EstudianteId, o => o.MapFrom(p => p.Estudiante.Id))
             .ForMember(x => x.Materia, o => o.MapFrom(p => p.Materia.Descripcion))
             .ForMember(x => x.MateriaId, o => o.MapFrom(p => p.Materia.Id))
             .ForMember(x => x.Periodo, o => o.MapFrom(p => p.Periodo.Descripcion))
             .ForMember(x => x.PeriodoId, o => o.MapFrom(p => p.Periodo.Id))
             .ForMember(x => x.DocenteId, o => o.MapFrom(p => p.Docente.Id))
           .ReverseMap();




        }
    }
}
