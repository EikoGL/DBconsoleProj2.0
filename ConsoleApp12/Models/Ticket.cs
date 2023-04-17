using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    internal class Ticket
    {
        [Key]
        public int IdTicket { get; set; }
        public string Passanger { get; set; }
        public string start_point { get; set; }
        public string end_point { get; set; }
        public string departure_details { get; set; }
        public string cost { get; set; }
    }
}
