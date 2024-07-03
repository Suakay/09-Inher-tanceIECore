using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_EFInheritance2.Entities
{
    internal class Customer:BasePerson
    {
           public DateTime AdmissionDate { get; set; }
        public int TotalVisits { get; set; }

    }
}
