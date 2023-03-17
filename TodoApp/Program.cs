using Microsoft.EntityFrameworkCore;
using TodoApp.Data;
using TodoApp.Repository;
using TodoApp.Repository.InMemory;
using TodoApp.Repository.MsSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Validation framework, DI asp.net core

// configure asp.net the ef library to connect for a db
builder.Services.AddDbContext<TodoDbContext>();
builder.Services.AddScoped<TodoDbContext, TodoDbContext>();
// DI object is configured by a constructor inject the object defined here 

// if test environment then work with inmemroy object
// else work with database
// asp.net automatically configures objects using DI concept
builder.Services.AddScoped<ITodoRepository, TodoDBRepository>();

// singleton - one object is create for the full application
// scoped - an object is created for all request response pipeline
// transient - a new object created for every request



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.Automigrate();

app.UseRouting();

app.UseAuthorization();

// it identifes the controllers folder list a set of url which it can prepare 
// /home
// /todo/GetAllTodos
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=GetAllTodos}/{id?}");

app.Run();
