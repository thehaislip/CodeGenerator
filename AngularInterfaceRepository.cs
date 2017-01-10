using System;

namespace CodeGenerator
{
    internal class AngularInterfaceRepository
    {
        private SchemaRepository schemaRepo;

        public AngularInterfaceRepository(SchemaRepository schemaRepo)
        {
            this.schemaRepo = schemaRepo;
        }

        internal string GetContextString(string database)
        {
            throw new NotImplementedException();
        }
    }
}