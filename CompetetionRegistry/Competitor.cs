using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetetionRegistry
{
    public class Competitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Category { get; set; }
        public Competitor(int id, string name, string surname, string category) {
            Id = id;
            Name = name;
            Surname = surname;
            Category = category;
        }

        public string Display { get { return string.Format("{0} {1} - Category: {2}", Name, Surname, Category); } }

    }
}
