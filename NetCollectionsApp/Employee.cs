using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCollectionsApp
{
    //class Employee : IComparable<Employee>
    //{
    //    public string Name { get; set; } = "";
    //    public int Age { get; set; }

    //    public int CompareTo(Employee? other)
    //    {
    //        return this.Name.CompareTo(other?.Name);
    //    }

    //    public override string ToString()
    //    {
    //        return $"Name: {Name}, Age: {Age}";
    //    }
    //}

    class Employee
    {
        public string Name { get; set; } = "";
        public int Age { get; set; } = 0;

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
