using CodeGenerator.GeneratorClases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Humanizer;

namespace CodeGenerator
{
    internal class ViewRepository
    {
        private SchemaRepository schemaRepo;
        private IEnumerable<DatabaseTable> tables;
        public ViewRepository(SchemaRepository schemaRepo)
        {
            this.schemaRepo = schemaRepo;
            tables = schemaRepo.ListTables();
        }

        internal string GetViewString(string database)
        {
            var sb = new StringBuilder();
            sb.GetUsings()
                .GetNamespace("GeneratedContext");
            foreach (var table in tables)
            {
                sb.GetClass($"{table.Name}View", "");
                foreach (var column in table.Columns)
                {
                    column.PrimaryKey = false;
                    sb.GetProperty(column,table.Name, isEntity: false);
                }
                foreach (var rel in table.NavigationProperties.Where(e => e.RelationshipType.ToLower() == "many"))
                {
                    sb.AppendLine($"IEnumerable<{rel.RelatedTable}> {rel.RelatedTable.Pluralize()}" + "{get; set;}");
                }
                sb.GetClassEnd();
            }
            sb.GetNamespaceEnd();
            return sb.ToString();
        }


    }
}