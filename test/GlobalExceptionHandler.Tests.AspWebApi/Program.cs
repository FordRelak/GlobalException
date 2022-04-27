using GlobalExceptionHandler;
using GlobalExceptionHandler.Tests.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<EntityService>();

var app = builder.Build();

app.UseRouting();

app.UseGlobalException(app.Services.GetService<IOptions<JsonOptions>>().Value.JsonSerializerOptions);

app.MapControllers();

app.Run();