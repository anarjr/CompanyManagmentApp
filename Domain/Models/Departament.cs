using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Departament : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
