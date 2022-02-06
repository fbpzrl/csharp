using Secao06.Exercicios.Entidades;
using System.Globalization;

namespace Secao06.Exercicios
{
    class ExercicioFixacao2
    {
        public ExercicioFixacao2()
        {
            Console.Write("Informe quantos empregados serão registrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();

                Console.WriteLine("Empregado #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Funcionario func = list.Find(x => x.Id == id);
                while (func != null && func.Id == id)
                {
                    Console.Write("Id existente. Informe outro: ");
                    id = int.Parse(Console.ReadLine());
                }

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine();

            Console.Write("Informe o Id do empregado que terá aumento salarial: ");
            int idFuncionario = int.Parse(Console.ReadLine());
            Funcionario funcionario = list.Find(x => x.Id == idFuncionario);

            if (funcionario != null)
            {
                Console.Write("Informe a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.aumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Funcionario obj in list)
            {
                if (obj != null)
                {
                    Console.WriteLine(obj);
                }
                
            }
        }
    }
}
