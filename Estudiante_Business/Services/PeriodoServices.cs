﻿using AutoMapper;
using Estudiante_Business.Interface;
using Estudiante_Business.Repository;
using Estudiante_Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiante_Business.Services
{
    public class PeriodoServices : BaseRepository<Periodos>, IPeriodoService
    {
        public PeriodoServices(DbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
