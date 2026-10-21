using Microsoft.EntityFrameworkCore;
using OnboardingApi.Data;
using OnboardingApi.Mappings;

using OnboardingApi.Repositories;
using OnboardingApi.Repositories.Interfaces;

using OnboardingApi.Services;
using OnboardingApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add Controllers
builder.Services.AddControllers();

// PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Repositories
builder.Services.AddScoped<IPersonalRepository, PersonalRepository>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IOnboardingRepository, OnboardingRepository>();

// Services
builder.Services.AddScoped<IPersonalService, PersonalService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IOnboardingService, OnboardingService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();