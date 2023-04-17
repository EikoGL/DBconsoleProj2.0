using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    internal class Passanger
    {
        [Key]
        public int IdPassanger { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string SurName { get; set; }
        public string Date_reg { get; set; }
    }
}
