using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

using BlogBackEnd;
using BlogBackEnd.Models;
using BlogBackEnd.Controllers;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("todo") ?? "Data Source=blogging.db";
builder.Services.AddSqlite<BlogDb>(connectionString);
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Users CRUD
PostControllers.Map("/Post", app);

app.Run();