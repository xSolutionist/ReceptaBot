using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptaBot.Shared.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public string Name { get; set; }
        public ICollection<Ingrediant> Ingrediants { get; set; } = new List<Ingrediant>();

    }
}
