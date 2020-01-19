namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int emoloyee_Id { get; set; }

        [StringLength(30)]
        public string emp_name { get; set; }

        [StringLength(30)]
        public string emp_postition { get; set; }

        public int? emp_age { get; set; }

        [Column(TypeName = "image")]
        public byte[] emp_salary { get; set; }

        [StringLength(30)]
        public string emp_EducLeve { get; set; }
    }
}
