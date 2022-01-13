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
        [DisplayName("�����W��")]
        public string FoodName { get; set; }

        [DisplayName("��������")]
        public int FoodPrice { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("����")]
        public string dep { get; set; }

        [Required]
        [DisplayName("�W��")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
