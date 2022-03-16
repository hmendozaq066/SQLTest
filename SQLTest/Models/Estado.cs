﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLTest.Models
{
    public class Estado
    {
        [Key]
        public int Estado_id { get; set; }
        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
