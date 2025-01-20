using FourCreate.ClinicalTrials.Domain.Services;
using FourCreate.ClinicalTrials.Infrastructure;
using FourCreate.ClinicalTrials.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var conf = builder.Configuration;
// Add services to the container.
services.AddDbContext<ClinicalTrialsContext>(
    options => options.UseNpgsql(conf.GetConnectionString("DbConnectionString")));
services.AddTransient<IClinicalTrialsSerivce, ClinicalTrialsSerivce>();
services.AddTransient<ICLinicalTrialsRepository, CLinicalTrialsRepository>();

services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

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
