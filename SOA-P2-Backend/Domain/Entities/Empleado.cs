﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Empleados")]
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public int id_people { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime date_hire { get; set; }
        [Required]
        public bool status { get; set; }
    }
}
