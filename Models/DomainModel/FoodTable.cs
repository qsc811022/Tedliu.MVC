namespace Tedliu.MVC.Models.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoodTable")]
    public partial class FoodTable
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("食物名稱")]
        public string FoodName { get; set; }

        [DisplayName("食物價格")]
        public int FoodPrice { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("部門")]
        public string dep { get; set; }

        [Required]
        [DisplayName("名稱")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
