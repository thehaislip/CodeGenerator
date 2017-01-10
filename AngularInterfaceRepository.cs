using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    internal class AngularInterfaceRepository
    {
        private SchemaRepository schemaRepo;
        private IEnumerable<DatabaseTable> tables;
        public AngularInterfaceRepository(SchemaRepository schemaRepo)
        {
            this.schemaRepo = schemaRepo;
            tables = schemaRepo.ListTables();
        }

        internal string GetInterfaceString(string database)
        {
            var sb = new StringBuilder();
            foreach (var table in tables)
            {
                sb.AppendLine($"export class {table.Name}")
                .Append("{")
                .AppendLine("constructor(){");
                foreach (var rel in table.NavigationProperties)
                {
                    if (rel.RelationshipType.ToLower() == "one")
                    {
                        sb.AppendLine($"this.{ rel.RelatedTable.Camelize()} = new {rel.RelatedTable}();");
                    }
                    else
                    {
                        sb.AppendLine($"this.{ rel.RelatedTable.Camelize().Pluralize()} = new Array<{rel.RelatedTable}>();");
                    }
                }
                sb.AppendLine("}");
                foreach (var column in table.Columns)
                {
                    GetProperty(sb, column);
                }
                foreach (var rel in table.NavigationProperties)
                {
                    if (rel.RelationshipType.ToLower() == "one")
                    {
                        sb.AppendLine($"{ rel.RelatedTable.Camelize()}:{rel.RelatedTable};");
                    }
                    else {
                        sb.AppendLine($"{ rel.RelatedTable.Camelize().Pluralize()}:Array<{rel.RelatedTable}>;");
                    }
                }
                sb.AppendLine("}");
            }
            return sb.ToString();
        }

        private void GetProperty(StringBuilder sb, DatabaseColumn col) {
            switch (col.DataType.ToLower())
            {
                case "int":
                case "decimal":
                case "float":
                case "money":
                    sb.AppendLine($"{col.Name.Camelize() }:number;");
                    break;
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldate":
                    sb.AppendLine($"{col.Name.Camelize() }:Date;");
                    break;
                default:
                    sb.AppendLine($"{col.Name.Camelize() }:string;");
                    break;
            }

        }
    }
}