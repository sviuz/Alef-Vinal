using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskToALEF.Models
{
    public class Model
    {
        public int Id { get; set;}
        [Required]
        [MinLength(3), MaxLength(3)]
        public int Value { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
