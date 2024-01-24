using Microsoft.EntityFrameworkCore;
using BlogBackEnd;
using BlogBackEnd.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("todo") ?? "Data Source=blogging.db";
builder.Services.AddSqlite<BlogDb>(connectionString);
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
