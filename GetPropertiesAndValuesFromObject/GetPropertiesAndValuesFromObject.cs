using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

/*
 * Programa to get a list of properties and value from Object
 */

namespace GetPropertiesAndValuesFromObject
{
    class GetPropertiesAndValuesFromObject
    {

        private Boss bossy;

        public Boss Bossy
        {
            get { return bossy; }
            set { bossy = value; }
        }


        private List<Employee> employees = new List<Employee>();

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }


        static void Main(string[] args)
        {
            GetPropertiesAndValuesFromObject program = new GetPropertiesAndValuesFromObject();

            
            //Creating and printing Employee properties
            Console.WriteLine("Creating and printing Employee properties");
            Employee e = program.generateEmployee("Paco Pérez", 41);
            IList<PropertyInfo> props = program.getProperties<Employee>(e);
            program.toStringPropertiesInfo <Employee>(props,e);

            //Adding Employee
            program.Employees.Add(e);

            Console.WriteLine("------------------------");

            //Creating and printing Boss properties
            Console.WriteLine("Creating and printing Boss properties");
            Boss b = program.generateBoss("Javier Pérez", 50);
            b.Employees = program.Employees;
            props = program.getProperties<Boss>(b);
            program.toStringPropertiesInfo<Boss>(props, b);

        }


        public void toStringPropertiesInfo<T>(IList<PropertyInfo> props, T t)
        {
            foreach (PropertyInfo prop in props)
            {
                Console.WriteLine("Propiedad: {0}, Valor: {1}", prop.Name, prop.GetValue(t, null).ToString());
            }
        }

        public IList<PropertyInfo> getProperties<T>(T t)
        {
            if (t != null)
            {
                Type @object = t.GetType();
                IList<PropertyInfo> props = new List<PropertyInfo>(@object.GetProperties());
                return props;
            }
            return null;
        }

        public Employee generateEmployee(string name, int age)
        {
            Employee employee = new Employee(name, age);
            Employees.Add(employee);

            return employee;

        }

        public Boss generateBoss(string name, int age)
        {
            Boss boss = new Boss(name, age);
            Bossy = boss;
            if (Employees != null)
            {
                Bossy.Employees = Employees;
            }
            return boss;

        }

        public void toStringJerarquia(Boss boss)
        {
            Console.WriteLine(String.Format("Orgranigrama: \n {0}", boss.ToString()));
        }

        /*
         * Method wich recive generic type
         */
        public void genericToString<T>(string message, ref T t)
        {
            Console.WriteLine(message + " {0}", t.ToString());
        }
    }

 
}
