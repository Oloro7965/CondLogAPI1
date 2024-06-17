using CondLogAPI.application.Commands.CreateUserCommand;
using CondLogAPI.Core.Domain.Repositories;
using CondLogAPI.Infraestructure.Persistance;
using CondLogAPI.Infraestructure.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(opt => opt.RegisterServicesFromAssemblyContaining(typeof(CreateUserCommand)));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IOcurrenceRepository, OcurrenceRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CondLogDbContext>(options =>
   options.UseInMemoryDatabase("Database"));
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
