using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDI
{
    class City : List<Library>
    {
        public string Name { get; set; }

        public City(string name)
        {
            Name = name;
        }

        public List<Library>Members => this;
    }
}
