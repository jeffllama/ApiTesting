using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Parent Parent { get; set; }
    }
}
