namespace CodeGenerator
{
    public class DatabaseRelationship
    {
        
        public string Column { get; internal set; }
        public string ColumnName { get; internal set; }
        public string RelatedColumn { get; internal set; }
        public string RelatedTable { get; internal set; }
        public string RelationshipType { get; internal set; }
        public string Table { get; internal set; }
    }
}