using SqlSugar;
using System;
using System.IO;
namespace EntityGenerator
{


    public class MainClass
    {
        public void GeneratorDBModel()
        {
            string connectionString = "server=139.9.219.213;port=3306;database=mall;user=root_lj;password=lj_dev";
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
