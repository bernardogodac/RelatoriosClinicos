﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaClinicaRelatorio.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime BirthDate { get; set; }
        public string CPF { get; set; }
        //public Enum Gender { get; set; }
        public string Age { get; internal set; }
        public int AddressId { get; set; }
        public virtual Address? Address { get; set; }

        public ICollection<Patient>? Patient { get; set; }
    }
}
