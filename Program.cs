using SqlSugar;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<SqlSugarClient>(provider =>
{
    return new SqlSugarClient(new ConnectionConfig()
    {
        ConnectionString =builder.Configuration.GetConnectionString("DefaultConnection"),
        DbType = DbType.MySql, // 设置数据库类型为 MySQL
        IsAutoCloseConnection = true, // 自动关闭连接
        InitKeyType = InitKeyType.Attribute // 初始化主键和自增列信息的方式
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

app.UseAuthorization();

app.MapControllers();

app.Run();
