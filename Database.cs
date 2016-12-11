namespace CodeGenerator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Database")]
    public partial class Database
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(500)]
        public string ConnectionString { get; set; }

        [StringLength(200)]
        public string Namespace { get; set; }
    }
}
