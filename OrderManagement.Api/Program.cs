using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using OrderManagement.BLL.Map;
using OrderManagement.BLL.Services;
using OrderManagement.DAL.Data;
using OrderManagement.DAL.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<OrderMgtDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("OrderMgtConnection"))
);

builder.Services.AddScoped<IRepository<ElementTypeDto>, ElementTypeRepository>();
builder.Services.AddScoped<IRepository<StateDto>, StateRepository>();
builder.Services.AddScoped<IRepository<OrderDto>, OrderRepository>();

builder.Services.AddScoped<IElementTypeService, ElementTypeService>();
builder.Services.AddScoped<IStateService, StateService>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddAutoMapper(typeof(AuthMapperProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
   policy.WithOrigins("http://localhost:7211", "https://localhost:7211")
   .AllowAnyMethod()
   .WithHeaders(HeaderNames.ContentType)
  );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
