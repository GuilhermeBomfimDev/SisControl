using Microsoft.EntityFrameworkCore;
using SisControlApi.Models;

var builder = WebApplication.CreateBuilder(args);

//Configura��o do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowGitHubPages", policy =>
    {
        policy.WithOrigins("https://agaidarji.github.io/SisControl/") // Ajuste para o seu dom�nio do GitHub Pages
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona o MySQL ao servi�o
builder.Services.AddDbContext<UserContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")!));

builder.Services.AddDbContext<ItemContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")!));

var app = builder.Build();

//Permite que a requisi��o HTTP acesse qualquer CORS
app.UseCors("AllowGitHubPages");

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
