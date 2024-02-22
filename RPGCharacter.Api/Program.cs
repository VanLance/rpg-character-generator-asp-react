using Microsoft.EntityFrameworkCore;
using RPGCharacter.Api.Data;
using RPGCharacter.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RpgCharacterDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RpgCharacterConnectionString")));

builder.Services.AddScoped<ICharacterRepository, SqlCharacterRepositiory>();

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
