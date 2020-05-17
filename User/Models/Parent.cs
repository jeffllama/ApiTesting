﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User.Models
{
    public class Parent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public ICollection<Child> Children { get; set; }
    }
}
