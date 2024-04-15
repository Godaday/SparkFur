using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SparkFur.Core.Interfaces;
using SparkFur.Core.Services;
using SparkFur.Infrastructure.DbContent;
using SparkFur.Infrastructure.Interfaces;
using SparkFur.Infrastructure.Repositorys;

var builder = WebApplication.CreateBuilder(args);
//读取配置文件    
//var configuration = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//    .Build();

// Add services to the container.
// 注册仓储服务

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<ISystemLogRepository, SystemLogRepository>();

// 注册服务

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<ISystemLogService, SystemLogService>();

// 注册数据库上下文

builder.Services.AddDbContext<SparkFurDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
