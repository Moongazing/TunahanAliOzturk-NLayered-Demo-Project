using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TunahanAliOzturk.API.Filters;
using TunahanAliOzturk.API.Middlewares;
using TunahanAliOzturk.Core.Repositories;
using TunahanAliOzturk.Core.Services;
using TunahanAliOzturk.Core.UnitOfWorks;
using TunahanAliOzturk.Repository;
using TunahanAliOzturk.Repository.Repositories;
using TunahanAliOzturk.Repository.UnitOfWorks;
using TunahanAliOzturk.Service.Mapping;
using TunahanAliOzturk.Service.Services;
using TunahanAliOzturk.Service.Validation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add(new ValidateFilterAttribute());
}).AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidatior>());

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
   });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddAutoMapper(typeof(MapProfile));

//Moving a autfac
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();


builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UserCustomException();

app.UseAuthorization();

app.MapControllers();

app.Run();
