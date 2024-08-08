using SqlSugar;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityGenerator
{

    public class EntityGenerator
    {
        public string OutputPath { get; set; }
        public string Namespace { get; set; }
        public string[] Prefixes { get; set; } = { "pms_", "cms_","ums_","sms_","oms_" }; // 预定义的前缀列表
        public void GenerateEntities(SqlSugarClient db)
        {
            var tableInfoList = db.DbMaintenance.GetTableInfoList();

            foreach (var tableInfo in tableInfoList)
            {
                GenerateEntity(db, tableInfo);
            }
        }

        public void GenerateEntity(SqlSugarClient db, DbTableInfo tableInfo)
        {
            var className = ToPascalCase(RemovePrefixes(tableInfo.Name)); // 更新为正确的属性
            var columns = db.DbMaintenance.GetColumnInfosByTableName(tableInfo.Name);

            var sb = new StringBuilder();
            sb.AppendLine($"namespace {Namespace}");
            sb.AppendLine("{");
            sb.AppendLine($"    public class {className}");
            sb.AppendLine("    {");

            foreach (var column in columns)
            {
                var propertyName = ToPascalCase(column.DbColumnName);
                if (propertyName == className)
                {
                    propertyName += "Property";
                }
                var nullable = column.IsNullable ? "?" : "";
                var type = MapSqlTypeToCSharp(column.DataType);
                string commentStr = FormatComment(column.ColumnDescription);
                if(commentStr != "")
                {
                    sb.Append($"        {commentStr}");
                }
                else
                {
                    sb.Append($"        {FormatComment(propertyName)}");
                }
                sb.AppendLine($"        public {type}{nullable} {propertyName} {{ get; set; }}\r");
            }

            sb.AppendLine("    }");
            sb.AppendLine("}");

            // Ensure the directory exists
            Directory.CreateDirectory(OutputPath);
            var filePath = Path.Combine(OutputPath, $"{className}.cs");
            File.WriteAllText(filePath, sb.ToString());
        }

        private string MapSqlTypeToCSharp(string sqlType)
        {
            // Basic mapping, expand as needed
            return sqlType switch
            {
                "int" => "int",
                "bigint" => "long",
                "varchar" => "string",
                "text" => "string",
                "datetime" => "DateTime",
                "decimal" => "decimal",
                "float" => "float",
                "double" => "double",
                "bit" => "bool",
                _ => "object"
            };
        }
        private string ToPascalCase(string input)
        {
            return string.Join("", input
                .Split('_')
                .Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower())
            );
        }
        private string RemovePrefixes(string tableName)
        {
            foreach (var prefix in Prefixes)
            {
                if (tableName.StartsWith(prefix))
                {
                    return tableName.Substring(prefix.Length);
                }
            }
            return tableName; // 如果没有匹配的前缀，返回原表名
        }
        private string FormatComment(string comment)
        {
            if (string.IsNullOrWhiteSpace(comment))
            {
                return "";
            }

         
            var lines = comment.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var formattedComment = new StringBuilder();

          
            formattedComment.AppendLine("/// <summary>");
            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();
                formattedComment.AppendLine($"        /// {trimmedLine}");
            }
            formattedComment.AppendLine("        /// </summary>");

            return formattedComment.ToString();
        }
    }


}
