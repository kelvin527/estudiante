using AutoMapper;
using Estudiante_Business.Interface;
using Estudiante_Business.Repository;
using Estudiante_Business.Services;
using Estudiante_Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<BaseContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("connection")));

builder.Services.AddTransient<IEstudianteService, EstudianteService>();
builder.Services.AddTransient<ICalificacionesService, CalificacionesServices>();
builder.Services.AddTransient<IMateriaService, MateriaServices>();
builder.Services.AddTransient<IPeriodoService, PeriodoServices>();
builder.Services.AddTransient<IDocenteService, DoceneteServices>();
builder.Services.AddTransient<IGradoService, GradoServices>();

var config = new MapperConfiguration(cf =>
{
    var asamble = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(x => x.GetName().Name == "Estudiante_Business");
    cf.AddMaps(asamble);
    cf.AllowNullCollections = true;
});

var mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();



/// Configure mmaper
/// 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
