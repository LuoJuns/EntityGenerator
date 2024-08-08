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
        DbType = DbType.MySql, // �������ݿ�����Ϊ MySQL
        IsAutoCloseConnection = true, // �Զ��ر�����
        InitKeyType = InitKeyType.Attribute // ��ʼ����������������Ϣ�ķ�ʽ
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
