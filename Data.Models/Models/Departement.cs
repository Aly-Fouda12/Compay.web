﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Models
{
    public class Departement : BaseEntity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public ICollection<Employee> Employees { get; set; }= new List<Employee>();
    }
}
