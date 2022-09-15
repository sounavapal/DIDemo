using DIDemo;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddScoped<IScoped, Scoped>();
//builder.Services.AddSingleton<Singleton, Singleton>();
//builder.Services.AddSingleton<Singleton>();
//builder.Services.AddTransient<IExample, Transient>();
builder.Services.AddTransient<IExample, Transient>();

// Why interaces
// an example of DI using concrete class without interface
// An example of DI using different implmentation of same interface
// an exacmple of DI without using ServiceProvider in the constructor. i.e directly 
// get the dependency

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//making changes
//sounava
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
