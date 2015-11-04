using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetPropertiesAndValuesFromObject
{
    public class Employee
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public Employee()
        {
        }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public override string ToString()
        {
            return String.Format("Name: {0} - Age: {1}", Name, Age);
        }
    }
}
