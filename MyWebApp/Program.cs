using Microsoft.EntityFrameworkCore;
using MyWebApp.Data;

var builder = WebApplication.CreateBuilder(args);

var connectionString= builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options=>
    options.UseSqlServer(connectionString));

var app = builder.Build();
app.MapGet("/",()=>"Db baglantisi hazir");

app.Run();

