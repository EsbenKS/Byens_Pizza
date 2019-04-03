using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PizzaBaren.Models
{
    public class Pizza { 
        public Guid Id { get; set; }
        public int PizzaNumber { get; set; }
        public string PizzaName { get; set; }
        public string Ingredients { get; set; }
        public int Pris { get; set; }
        
    }
}
