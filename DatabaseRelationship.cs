namespace CodeGenerator
{
    public class DatabaseRelationship
    {
        public string ChildTable { get; internal set; }
        public string FKColumn { get; internal set; }
        public string ParentTable { get; internal set; }
        public string PKColumn { get; internal set; }
    }
}