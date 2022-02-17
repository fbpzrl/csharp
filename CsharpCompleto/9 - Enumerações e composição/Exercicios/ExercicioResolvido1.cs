using Secao09.Entities;
using Secao09.Entities.Enums;
using System.Globalization;

namespace Secao09.Exercicios
{
    class ExercicioResolvido1
    {
        public ExercicioResolvido1()
        {
            Console.Write("Enter Department's name: ");
            string departmentName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, level, baseSalary, new Department(departmentName));

            Console.WriteLine();

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.Write("Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration: ");
                int hour = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, valuePerHour, hour));

                Console.WriteLine();
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] monthYear = Console.ReadLine().Split('/');
            int month = int.Parse(monthYear[0]);
            int year = int.Parse(monthYear[1]);
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine($"Income for {month}/{year}: " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
