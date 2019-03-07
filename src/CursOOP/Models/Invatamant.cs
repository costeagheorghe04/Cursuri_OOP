using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursOOP.Models
{
    public class Invatamant : Cladiri
    {
        public int Id { get; set; }
        public string Destinat { get; set; }
        public int AgeRange { get; set; }
    
    }
}
