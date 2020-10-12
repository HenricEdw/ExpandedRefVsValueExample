using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsRefTypes2
{
    enum Department
    {
        HR,
        IT
    }
    class Employee
    {
        public string Name { get;  set; }
        public Department Avdelning { get; set; }

        public Employee(string namn, Department department)
        {
            Name = namn;
            Avdelning = department;
        }


    }
}
