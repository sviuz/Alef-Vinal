using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestTaskToALEF.DataModels
{
    public class ModelData
    {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
    }
}
