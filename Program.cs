using EntityGenerator;
using SqlSugar;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<MainClass>();
builder.Services.AddScoped<ISqlSugarClient>(provider =>
{
    return new SqlSugarClient(new ConnectionConfig()
    {
        ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new Exception("Connection string not found"),
        DbType = (DbType)Enum.Parse(typeof(DbType), builder.Configuration.GetConnectionString("DefaultDbType") ?? throw new Exception("Database type not found")),
        IsAutoCloseConnection = true // 自动关闭连接
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
