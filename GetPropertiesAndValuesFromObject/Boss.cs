using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetPropertiesAndValuesFromObject
{
    class Boss : Employee
    {
        List<Employee> employees;

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public Boss()
            : base()
        { }

        public Boss(string name, int age)
            : base(name, age)
        {

        }

        public Boss(string name, int age, List<Employee> employees)
            : base(name, age)
        {
            Employees = employees;
        }

        public void add(Employee employee)
        {
            if (Employees != null)
            {
                Employees.Add(employee);
            }
        }

        public override string ToString()
        {
            string result = String.Format("Responsable -> {0}", base.ToString());
            if (Employees != null)
            {
                result += "\n Personal a cargo:";
                foreach (Employee e in Employees)
                {
                    result += "\n\t" + e.ToString();
                }
            }
            return result;
        }
    }
}
