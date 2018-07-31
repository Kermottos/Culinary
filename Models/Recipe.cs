using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CulinaryApp.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Products { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public int Difficulty { get; set; }
        public int Rating { get; set; }
    }
}
