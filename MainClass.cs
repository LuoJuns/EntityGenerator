using SqlSugar;
using System;
using System.IO;
namespace EntityGenerator
{


    public class MainClass(ISqlSugarClient db)
    {
        public void GeneratorDBModel()
        {
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

        /// <summary>
        /// 根据表明生成实体类
        /// </summary>
        /// <param name="tableName"></param>
        public void GeneratorDBModel(string tableName)
        {
            var tableInfo = db.DbMaintenance.GetTableInfoList().Where(t => t.Name.ToLower() == tableName.ToLower()).FirstOrDefault();
            var entityGenerator = new EntityGenerator
            {
                OutputPath = "Models",
                Namespace = "EntityGenerator"
            };

            if (tableInfo != null)
                entityGenerator.GenerateEntity(db, tableInfo);

            Console.WriteLine("Entity classes generated.");
        }
    }

}
