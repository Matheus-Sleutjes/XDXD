using Microsoft.EntityFrameworkCore;
using Stefanini.Data.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Context 

builder.Services.AddDbContext<StefaniniContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StefaniniDb")));

var app = builder.Build();

var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope();
var context = serviceScope.ServiceProvider.GetRequiredService<StefaniniContext>();
context.Database.Migrate();


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();
