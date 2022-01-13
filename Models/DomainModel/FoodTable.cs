namespace Tedliu.MVC.Models.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodTable")]
    public partial class FoodTable
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string FoodName { get; set; }

        public int FoodPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string dep { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
