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
            CreateMap<Grados, GradoDto>().ReverseMap();
            CreateMap<Materias, MateriaDto>().ReverseMap();
            CreateMap<Periodos, PeriodoDto>().ReverseMap();
            CreateMap<Calificaciones, CalificacionesDto>().ReverseMap();
            CreateMap<CalificacionesDto, Estudiante_Data.Models.CalificacionesResponseModel>()
            .ForMember(x => x.Estudiante, o => o.MapFrom(p => p.Estudiante.NombresCompleto))
            .ForMember(x => x.Docente, o => o.MapFrom(p => p.Docente.NombresCompleto))
            .ForMember(x => x.Grado, o => o.MapFrom(p => p.Estudiante.Grado))
            .ForMember(x => x.Sexo, o => o.MapFrom(p => p.Estudiante.Sexo))
           .ReverseMap();
            CreateMap<CalificacionesDto, Estudiante_Data.Models.CalificacionesModel>()
             .ForMember(x => x.Periodo, o => o.MapFrom(p => p.Periodo.Descripcion))
             .ForMember(x => x.Materia, o => o.MapFrom(p => p.Materia.Descripcion))
             .ForMember(x => x.Nota, o => o.MapFrom(p => p.Nota))
            .ReverseMap();
            CreateMap<Estudiantes, EstudianteDto>()
                .ForMember(x => x.Grado, o => o.MapFrom(p => p.Grado.Descripcion)).ReverseMap();
            CreateMap<Docentes, DocenteDto>().ReverseMap();
        }
    }
}
