namespace CodeGenerator
{
    public class DatabaseRelationship
    {
        
        public string Column { get; internal set; }
        public string RelationshipType { get; internal set; }
        public string Table { get; internal set; }
    }
}