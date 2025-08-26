using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using S4.LigaFutbol.DAC;
using S4.LigaFutbol.Repositorio.Catalogos.Extensiones;
using S4.LigaFutbol.Repositorio.Estadisticas.Extensiones;
using S4.LigaFutbol.Repositorio.Operacion.Extensiones;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Conexion a BD
builder.Services.AddSingleton(new Conexion(builder.Configuration.GetConnectionString("SQL")!));

//Clases Extensiones para cada Clase
//Clases
builder.Services.addFaseTorneoExtension();
builder.Services.addPosicionTorneoExtension();
builder.Services.addTipoImagenExtension();
builder.Services.addTipoMovimientoExtension();
builder.Services.addTipoPartidoExtension();
builder.Services.addTipoSancionExtension();
//Estadisticas
builder.Services.addEstadisticasExtension();
//Operacion
builder.Services.addEquipoExtension();
builder.Services.addGolExtension();
builder.Services.addJugadorExtension();
builder.Services.addPartidoExtension();
builder.Services.addSancionExtension();
builder.Services.addTorneoExtension();



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
