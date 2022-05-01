using Secao10.Entities;
using System.Globalization;

namespace Secao10.Exercicios
{
    class ExercicioResolvido_Heranca
    {
        public ExercicioResolvido_Heranca()
        {
            List<Employee> emp = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + " data:");
                Console.Write("Outsourced (y/n)? ");
                char input = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (input == 'y') 
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Add(new OutsourcedEmployee(additionalCharge, name, hours, valuePerHour));
                }
                else
                    emp.Add(new Employee(name, hours, valuePerHour));

                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee employee in emp)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
