using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    internal class Point
    {
        [Key]
        public int IdPoint { get; set; }
        public string Num { get; set; }
    }
}
