namespace ConsoleApplication11entity2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class buses
    {
        public int? Id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int route { get; set; }
        public override string ToString()
        {
            return $"Id = {Id}, name = {name}, route = {route},";
        }
    }
}
