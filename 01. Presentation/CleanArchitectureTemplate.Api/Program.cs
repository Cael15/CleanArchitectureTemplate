using AutoMapper;
using CleanArchitectureTemplate.Api.Configuration;
using CleanArchitectureTemplate.Infrastructure.Mapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.UseDependencyInjectorConfiguration(builder.Configuration);
builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddSwaggerGen();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfile());
});

var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
