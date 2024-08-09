using SqlSugar;
using System;
using System.IO;
namespace EntityGenerator
{


    public class MainClass
    {
        public void GeneratorDBModel()
        {
            string connectionString = "Server=myServerAddress;Database=myDatabase;User Id=myUsername;Password=myPassword;";
            //string connectionString = "server=127.0.0.1;port=3306;database=YourDatabase;user=your_username;password=your_password";
            var db = new SqlSugarClient(new ConnectionConfig
            {
                ConnectionString = connectionString,
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });

            var tableInfoList = db.DbMaintenance.GetTableInfoList();
            var entityGenerator = new EntityGenerator
            {
                OutputPath = "Models",
                Namespace = "EntityGenerator"
            };

            foreach (var tableInfo in tableInfoList)
            {
                entityGenerator.GenerateEntity(db, tableInfo);
            }

            Console.WriteLine("Entity classes generated.");
        }
    }

}
