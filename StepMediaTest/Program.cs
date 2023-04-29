using Microsoft.EntityFrameworkCore;
using StepMediaTest.Repositories;
using StepMediaTest.Repositories.Interfaces;
using StepMediaTest.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StepMediaDbContext>(options => options.UseSqlServer("name=ConnectionStrings:sqlConnection"));

builder.Services.AddScoped<IRepositories, Repositories>();
builder.Services.AddScoped<IServices, Services>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
