using Microsoft.EntityFrameworkCore;
using TaskAPI.Controllers;
using TaskAPI.Data;
using TaskAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//dependancy injection
builder.Services.AddScoped<ITasksRepository, TaskSQLServerService>();
builder.Services.AddScoped<IAuthorsRepository, AuthorSQLServerService>();
//builder.Services.ConfigureServices(
//    services =>
//        services.AddHostedService<TasksController>()
//            .AddScoped<ITasksRepository, DummyData>());

builder.Services.AddDbContext<TaskDBContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
