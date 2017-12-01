namespace CodeGenerator.GeneratorClases
{
    internal class ClassDefinition
    {
        public ClassDefinition()
        {

        }
        public ClassDefinition(string className, string def)
        {
            this.ClassName = className;
            this.Definition = def;
        }
        public string ClassName { get; set; }
        public string Definition { get; set; }
    }
}